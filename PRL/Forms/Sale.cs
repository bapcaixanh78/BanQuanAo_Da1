using BUS.Services;
using DAL.Model;

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
            dtg_Sale.ColumnCount = 8;
            dtg_Sale.Columns[0].Name = "STT";
            dtg_Sale.Columns[1].Name = "Tên Khuyến mãi";
            dtg_Sale.Columns[2].Name = "Thời gian bắt đầu";
            dtg_Sale.Columns[3].Name = "Thời gian kết thúc";
            dtg_Sale.Columns[4].Name = "Giảm giá";
            dtg_Sale.Columns[5].Name = "Mô tả";
            dtg_Sale.Columns[6].Name = "ID";
            dtg_Sale.Columns[6].Visible = false;
            dtg_Sale.AllowUserToAddRows = false;
            int stt = 1;
            foreach (var item in khuyenmais)
            {
                dtg_Sale.Rows.Add(stt++, item.Tenmakhuyenmai, item.Thoigianbatdau, item.Thoigianketthuc, item.Giamgia, item.Mota, item.Id);
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
            saleSV.Update(currentId, khuyenmaiUpdate);
            List<Khuyenmai> khuyenmais = saleSV.GetKM();
            LoadDataToGridview(khuyenmais);
        }

        private void btn_Add_Click(object sender, EventArgs e)
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
            saleSV.Add(khuyenmai);
            List<Khuyenmai> khuyenmais = saleSV.GetKM();
            LoadDataToGridview(khuyenmais);
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            List<Khuyenmai> khuyenmais = saleSV.GetKhuyenMaiByName(txt_Search.Text);
            LoadDataToGridview(khuyenmais);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Guid currentId = (Guid)dtg_Sale.CurrentRow.Cells[6].Value;
            saleSV.Delete(currentId);
            List<Khuyenmai> khuyenmais = saleSV.GetKM();
            LoadDataToGridview(khuyenmais);
        }
    }
}