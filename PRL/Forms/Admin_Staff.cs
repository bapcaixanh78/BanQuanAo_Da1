using BUS.Services;
using BUS.Utilites;
using DAL.Model;

namespace PRL.Forms
{
    public partial class Admin_Staff : Form
    {
        private StaffSV staffSV = new StaffSV();

        public Admin_Staff()
        {
            InitializeComponent();
        }

        public Admin_Staff(StaffSV staffSV)
        {
            this.staffSV = staffSV;
        }

        public void LoadDataToGridview(List<Nhanvien> nhanviens)
        {
            dtg_NhanVien.DataSource = null;
            dtg_NhanVien.Rows.Clear();//Clear dữ liệu trước khi tìm kiếm
            dtg_NhanVien.ColumnCount = 10;
            dtg_NhanVien.Columns[0].Name = "STT";
            dtg_NhanVien.Columns[1].Name = "Tên nhân viên";
            dtg_NhanVien.Columns[2].Name = "Tài khoản";
            dtg_NhanVien.Columns[3].Name = "Mật khẩu";
            dtg_NhanVien.Columns[4].Name = "Địa chỉ";
            dtg_NhanVien.Columns[5].Name = "Email";
            dtg_NhanVien.Columns[6].Name = "Ngày tạo";
            dtg_NhanVien.Columns[7].Name = "Quyền";
            dtg_NhanVien.Columns[8].Name = "Trạng thái";
            dtg_NhanVien.Columns[9].Name = "ID";
            dtg_NhanVien.Columns[9].Visible = false;
            dtg_NhanVien.AllowUserToAddRows = false;
            int stt = 1;
            foreach (var item in nhanviens)
            {
                dtg_NhanVien.Rows.Add(stt++, item.Ten, item.Taikhoan, item.Matkhau, item.Diachi, item.Email, item.Ngaytao, item.Quyen == 0 ? "Quản lý" : "Nhân viên", item.Trangthai, item.Id);
            }
        }

        private void Admin_Staff_Load(object sender, EventArgs e)
        {
            cbb_role.SelectedIndex = 0;
            List<Nhanvien> nhanviens = staffSV.GetAll();
            LoadDataToGridview(nhanviens);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (StaffValidate.CheckEmptyString(txt_TenNV.Text) == false ||
                StaffValidate.CheckEmptyString(txt_Account.Text) == false ||
                StaffValidate.CheckEmptyString(txt_Password.Text) == false ||
                StaffValidate.CheckEmptyString(txt_DiaChi.Text) == false ||
                StaffValidate.CheckEmptyString(txt_email.Text) == false)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }
            if (!StaffValidate.CheckIfContainNumber(txt_TenNV.Text))
            {
                MessageBox.Show("Name can't contains number");
                return;
            }
            if (StaffValidate.CheckIfContainSymbol(txt_Account.Text))
            {
                MessageBox.Show("Name can't contain symbols");
                return;
            }
            if (StaffValidate.CheckIfStaffAccountNameExist(txt_Account.Text))
            {
                MessageBox.Show("Account name already exist");
                return;
            }
            if (!StaffValidate.CheckEmail(txt_email.Text))
            {
                MessageBox.Show("Check email format");
                return;
            }
            else
            {
                Nhanvien nhanvien = new Nhanvien()
                {
                    Id = new Guid(),
                    Ten = txt_TenNV.Text,
                    Taikhoan = txt_Account.Text,
                    Matkhau = txt_Password.Text,
                    Diachi = txt_DiaChi.Text,
                    Email = txt_email.Text,
                    Quyen = cbb_role.SelectedIndex == 0 ? 0 : 1,
                    Ngaytao = DateTime.Now,
                    Trangthai = "Hoạt động"
                };
                staffSV.Add(nhanvien);
                List<Nhanvien> nhanviens = staffSV.GetAll();
                LoadDataToGridview(nhanviens);
            }
        }

        private void dtg_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_TenNV.Text = dtg_NhanVien.CurrentRow.Cells[1].Value.ToString();
            txt_Account.Text = dtg_NhanVien.CurrentRow.Cells[2].Value.ToString();
            txt_Password.Text = dtg_NhanVien.CurrentRow.Cells[3].Value.ToString();
            txt_DiaChi.Text = dtg_NhanVien.CurrentRow.Cells[4].Value.ToString();
            txt_email.Text = dtg_NhanVien.CurrentRow.Cells[5].Value.ToString();
            if (dtg_NhanVien.CurrentRow.Cells[7].Value.ToString() == "Quản lý")
            {
                cbb_role.SelectedIndex = 0;
            }
            else
            {
                cbb_role.SelectedIndex = 1;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Check chuỗi rỗng
            if (StaffValidate.CheckEmptyString(txt_TenNV.Text) == false ||
                StaffValidate.CheckEmptyString(txt_Account.Text) == false ||
                StaffValidate.CheckEmptyString(txt_Password.Text) == false ||
                StaffValidate.CheckEmptyString(txt_DiaChi.Text) == false ||
                StaffValidate.CheckEmptyString(txt_email.Text) == false)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            //Check xem tên có chứa số hay không
            if (!StaffValidate.CheckIfContainNumber(txt_TenNV.Text))
            {
                MessageBox.Show("Name can't contains number");
                return;
            }
            if (StaffValidate.CheckIfContainSymbol(txt_Account.Text))
            {
                MessageBox.Show("Name can't contain symbols");
                return;
            }

            //Check xem tên tài khoản đã tồn tại chauw
            if (StaffValidate.CheckIfStaffAccountNameExistUpdate(dtg_NhanVien.CurrentRow.Cells[1].Value.ToString(), txt_Account.Text))
            {
                MessageBox.Show("Account's name already exist");
                return;
            }

            //Check định dạng email
            if (!StaffValidate.CheckEmail(txt_email.Text))
            {
                MessageBox.Show("Check email format");
                return;
            }
            else
            {
                Guid currentID = (Guid)dtg_NhanVien.CurrentRow.Cells[9].Value;
                Nhanvien nhanVienUpdate = new Nhanvien()
                {
                    Id = currentID,
                    Ten = txt_TenNV.Text,
                    Taikhoan = txt_Account.Text,
                    Matkhau = txt_Password.Text,
                    Diachi = txt_DiaChi.Text,
                    Email = txt_email.Text,
                    Quyen = cbb_role.SelectedValue == "Quản lý" ? 0 : 1,
                };
                staffSV.Update(currentID, nhanVienUpdate);
                List<Nhanvien> nhanviens = staffSV.GetAll();
                LoadDataToGridview(nhanviens);
            }
        }

        private void btn_Lock_Click(object sender, EventArgs e)
        {
            Guid currentID = (Guid)dtg_NhanVien.CurrentRow.Cells[9].Value;
            staffSV.Lock(currentID);
            List<Nhanvien> nhanviens = staffSV.GetAll();
            LoadDataToGridview(nhanviens);
        }

        private void txt_TimKiemNV_TextChanged(object sender, EventArgs e)
        {
            List<Nhanvien> nhanviens = staffSV.GetStaffByName(txt_TimKiemNV.Text);
            LoadDataToGridview(nhanviens);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_TenNV.Text = string.Empty;
            txt_Account.Text = string.Empty;
            txt_Password.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_DiaChi.Text = string.Empty;
        }
    }
}