
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;


namespace PRL.Forms
{
    public partial class Main : Form
    {
        private Button currentButton;
        private Form activeForm;


        public Main()
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
        }

        private void btn_KhachHang_MouseEnter(object sender, EventArgs e)
        {
            btn_KhachHang.Font = new Font(btn_KhachHang.Font.FontFamily, 14);

        }

        private void btn_KhachHang_MouseLeave(object sender, EventArgs e)
        {
            btn_KhachHang.Font = new Font(btn_KhachHang.Font.FontFamily, 12);
        }

        private void btn_SanPham_MouseEnter(object sender, EventArgs e)
        {
            btn_SanPham.Font = new Font(btn_SanPham.Font.FontFamily, 14);
        }

        private void btn_SanPham_MouseLeave(object sender, EventArgs e)
        {
            btn_SanPham.Font = new Font(btn_SanPham.Font.FontFamily, 12);

        }

        private void btn_NhanVien_MouseEnter(object sender, EventArgs e)
        {
            btn_NhanVien.Font = new Font(btn_NhanVien.Font.FontFamily, 14);
        }

        private void btn_NhanVien_MouseLeave(object sender, EventArgs e)
        {
            btn_NhanVien.Font = new Font(btn_NhanVien.Font.FontFamily, 12);
        }

        private void btn_HoaDon_MouseEnter(object sender, EventArgs e)
        {
            btn_HoaDon.Font = new Font(btn_HoaDon.Font.FontFamily, 14);
        }

        private void btn_HoaDon_MouseLeave(object sender, EventArgs e)
        {
            btn_HoaDon.Font = new Font(btn_HoaDon.Font.FontFamily, 12);
        }

        private void btn_BanHang_MouseEnter(object sender, EventArgs e)
        {
            btn_BanHang.Font = new Font(btn_BanHang.Font.FontFamily, 14);
        }

        private void btn_BanHang_MouseLeave(object sender, EventArgs e)
        {
            btn_BanHang.Font = new Font(btn_BanHang.Font.FontFamily, 12);
        }

        private void btn_ThongKe_MouseEnter(object sender, EventArgs e)
        {
            btn_ThongKe.Font = new Font(btn_ThongKe.Font.FontFamily, 14);
        }

        private void btn_ThongKe_MouseLeave(object sender, EventArgs e)
        {
            btn_ThongKe.Font = new Font(btn_ThongKe.Font.FontFamily, 12);
        }



        private void btn_KhuyenMai_MouseEnter(object sender, EventArgs e)
        {
            btn_KhuyenMai.Font = new Font(btn_KhuyenMai.Font.FontFamily, 14);
        }

        private void btn_KhuyenMai_MouseLeave(object sender, EventArgs e)
        {
            btn_KhuyenMai.Font = new Font(btn_KhuyenMai.Font.FontFamily, 12);
        }

        private void btn_DangXuat_MouseEnter(object sender, EventArgs e)
        {
            btn_DangXuat.Font = new Font(btn_DangXuat.Font.FontFamily, 14);
        }

        private void btn_DangXuat_MouseLeave(object sender, EventArgs e)
        {
            btn_DangXuat.Font = new Font(btn_DangXuat.Font.FontFamily, 12);
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Admin_Customers2(), sender);
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pn_ChucNang.Controls.Add(childForm);
            this.pn_ChucNang.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {


                    btnCloseChildForm.Visible = true;
                }
            }
        }



        private void Reset()
        {


            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Admin_Products(), sender);
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Admin_Staff(), sender);
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Admin_Bill(), sender);
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Vending2(), sender);
        }

        private void btn_KhuyenMai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Sale(), sender);
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Statistics(), sender);
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {

        }
    }
}
