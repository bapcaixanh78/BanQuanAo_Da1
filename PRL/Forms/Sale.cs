using BUS.IServices;
using BUS.Services;
using BUS.Utilites;
using DAL.Model;
using PdfSharp.Drawing;

namespace PRL.Forms
{
    public partial class Sale : Form
    {
        private SaleSV saleSV = new SaleSV();

        public Sale()
        {
            InitializeComponent();
        }

        public Sale(SaleSV saleSV)
        {
            this.saleSV = saleSV;
        }

        public void LoadDataToGridview(List<Khuyenmai> khuyenmais)
        {
            dtg_Sale.DataSource = null;
            dtg_Sale.Rows.Clear();//Clear dữ liệu trước khi tìm kiếm
            foreach(DataGridViewRow row in dtg_Sale.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
            dtg_Sale.ColumnCount = 8;
            dtg_Sale.Columns[0].Name = "STT";
            dtg_Sale.Columns[1].Name = "Tên Khuyến mãi";
            dtg_Sale.Columns[2].Name = "Thời gian bắt đầu";
            dtg_Sale.Columns[3].Name = "Thời gian kết thúc";
            dtg_Sale.Columns[4].Name = "Giảm giá";
            dtg_Sale.Columns[5].Name = "Mô tả";
            dtg_Sale.Columns[6].Name = "ID";
            dtg_Sale.Columns[7].Name = "Trạng thái";
            dtg_Sale.Columns[6].Visible = false;
            dtg_Sale.AllowUserToAddRows = false;
            int stt = 1;

            for (int i = 0; i < khuyenmais.Count; i++)
            {
                dtg_Sale.Rows.Add(stt++, khuyenmais[i].Tenmakhuyenmai, khuyenmais[i].Thoigianbatdau, khuyenmais[i].Thoigianketthuc, khuyenmais[i].Giamgia, khuyenmais[i].Mota, khuyenmais[i].Id, khuyenmais[i].Trangthai);
                if (khuyenmais[i].Trangthai == "Dừng hoạt động")
                {
                    dtg_Sale.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                    dtg_Sale.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    dtg_Sale.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dtg_Sale.Rows[i].DefaultCellStyle.ForeColor = Color.White;

                }
            }
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            List<Khuyenmai> khuyenmais = saleSV.GetKM();
            LoadDataToGridview(khuyenmais);
        }

        private void dtg_Sale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_TenSale.Text = dtg_Sale.CurrentRow.Cells[1].Value.ToString();
            dtpk_StartDate.Value = (DateTime)dtg_Sale.CurrentRow.Cells[2].Value;
            dtpk_EndDate.Value = (DateTime)dtg_Sale.CurrentRow.Cells[3].Value;
            txt_MinBill.Text = dtg_Sale.CurrentRow.Cells[4].Value.ToString();
            txt_MoTa.Text = dtg_Sale.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {       // track ngày kết thúc lớn nhất là 1 năm tính từ ngày bắt đầu
            if (!SaleValidate.CheckEnddatetoolong(dtpk_EndDate.Value, dtpk_StartDate.Value))
            {
                MessageBox.Show("The end date can't exceed 1 year from the start date", "Inform");
                return;
            }
            // ngày bắt đầu mới phải bằng hoặc sau ngày bắt đầu cũ
            if (SaleValidate.CheckifstartdateUpdate(dtpk_StartDate.Value, DateTime.Parse(dtg_Sale.CurrentRow.Cells[2].Value.ToString())))
            {
                MessageBox.Show("New start date has to be the same or greater than the old one", "Inform");
                return;
            }
            //  check ngày hết tồn tại trước ngày bắt đầu
            if (SaleValidate.Checkifstartdatelaterenddate(dtpk_StartDate.Value, dtpk_EndDate.Value))
            {
                MessageBox.Show("End date can't be before start date", "Inform");
                return;
            }
            // check tên sale đã tồn tại
            if (SaleValidate.CheckIfSaleNameExistUpdate(dtg_Sale.CurrentRow.Cells[1].Value.ToString(), txt_TenSale.Text))
            {
                MessageBox.Show("Name already exist!", "Inform");
                return;
            }
            else
            {
                Guid currentId = (Guid)dtg_Sale.CurrentRow.Cells[6].Value;
                Khuyenmai khuyenmaiUpdate = new Khuyenmai()
                {
                    Id = currentId,
                    Tenmakhuyenmai = txt_TenSale.Text,
                    Thoigianbatdau = dtpk_StartDate.Value,
                    Thoigianketthuc = dtpk_EndDate.Value,
                    Giamgia = int.Parse(txt_MinBill.Text),
                    Mota = txt_MoTa.Text
                };

                var option = MessageBox.Show("Confirm", "Notification", MessageBoxButtons.YesNo);
                if (option == DialogResult.Yes)
                {
                    MessageBox.Show(saleSV.Update(currentId, khuyenmaiUpdate));
                    clear();
                }
                else
                {
                    return;
                }
                List<Khuyenmai> khuyenmais = saleSV.GetKM();
                LoadDataToGridview(khuyenmais);
                clear();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            // track ngày kết thúc lớn nhất là 1 năm tính từ ngày bắt đầu
            if (!SaleValidate.CheckEnddatetoolong(dtpk_EndDate.Value, dtpk_StartDate.Value))
            {
                MessageBox.Show("The end date can't exceed 1 year from the start date", "Inform");
                return;
            }
            // ngày bắt đầu mới phải bằng hoặc sau ngày tạo
            if (!SaleValidate.Checkifstartdate(dtpk_StartDate.Value))
            {
                MessageBox.Show("New discount start date has to be greater than current date", "Inform");
                return;
            }
            //  check ngày hết tồn tại trước ngày bắt đầu
            if (SaleValidate.Checkifstartdatelaterenddate(dtpk_StartDate.Value, dtpk_EndDate.Value))
            {
                MessageBox.Show("End date can't be before start date", "Inform");
                return;
            }
            // check tên sale đã tồn tại
            if (SaleValidate.CheckIfSaleNameExist(txt_TenSale.Text))
            {
                MessageBox.Show("Name already exist", "Inform");
                return;
            }
            else
            {
                Khuyenmai khuyenmai = new Khuyenmai()

                {
                    Id = new Guid(),
                    Tenmakhuyenmai = txt_TenSale.Text,
                    Thoigianbatdau = dtpk_StartDate.Value,
                    Thoigianketthuc = dtpk_EndDate.Value,
                    Giamgia = int.Parse(txt_MinBill.Text),
                    Mota = txt_MoTa.Text
                };
                khuyenmai.Trangthai = ("Hoạt động");

                var option = MessageBox.Show("Confirm", "Notification", MessageBoxButtons.YesNo);
                if (option == DialogResult.Yes)
                {
                    MessageBox.Show(saleSV.Add(khuyenmai));
                    clear();
                }
                else
                {
                    return;
                }
                List<Khuyenmai> khuyenmais = saleSV.GetKM();
                LoadDataToGridview(khuyenmais);
                clear();
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            List<Khuyenmai> khuyenmais = saleSV.GetKhuyenMaiByName(txt_Search.Text);
            LoadDataToGridview(khuyenmais);
        }

        public void clear()
        {
            txt_TenSale.Text = null;
            txt_MinBill.Text = null;
            dtpk_EndDate.Value = DateTime.Now;
            dtpk_StartDate.Value = DateTime.Now;
            txt_MoTa.Text = null;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Guid currentID = (Guid)dtg_Sale.CurrentRow.Cells[6].Value;
            var lstKM = saleSV.GetKM();
            foreach (Khuyenmai khuyenmai in lstKM)
            {
                if (khuyenmai.Id == currentID)
                {
                    if (khuyenmai.Thoigianketthuc <= DateTime.Today)
                    {
                        MessageBox.Show("Can't unlock a discount that has expired");
                        return;
                    }
                }
            };
            var option = MessageBox.Show("Confirm", "Inform", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                saleSV.Delete(currentID);
                List<Khuyenmai> khuyenmais = saleSV.GetKM();
                LoadDataToGridview(khuyenmais);
                clear();
            }
            else
            {
                return;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}