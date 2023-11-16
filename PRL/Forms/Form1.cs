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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_KhachHang_MouseEnter(object sender, EventArgs e)
        {
            btn_KhachHang.Font = new Font(btn_KhachHang.Font.FontFamily, 11);

        }

        private void btn_KhachHang_MouseLeave(object sender, EventArgs e)
        {
            btn_KhachHang.Font = new Font(btn_KhachHang.Font.FontFamily, 9);
        }

        private void btn_SanPham_MouseEnter(object sender, EventArgs e)
        {
            btn_SanPham.Font = new Font(btn_SanPham.Font.FontFamily, 11);
        }

        private void btn_SanPham_MouseLeave(object sender, EventArgs e)
        {
            btn_SanPham.Font = new Font(btn_SanPham.Font.FontFamily, 9);

        }

        private void btn_NhanVien_MouseEnter(object sender, EventArgs e)
        {
            btn_NhanVien.Font = new Font(btn_NhanVien.Font.FontFamily, 11);
        }

        private void btn_NhanVien_MouseLeave(object sender, EventArgs e)
        {
            btn_NhanVien.Font = new Font(btn_NhanVien.Font.FontFamily, 9);
        }

        private void btn_HoaDon_MouseEnter(object sender, EventArgs e)
        {
            btn_HoaDon.Font = new Font(btn_HoaDon.Font.FontFamily, 11);
        }

        private void btn_HoaDon_MouseLeave(object sender, EventArgs e)
        {
            btn_HoaDon.Font = new Font(btn_HoaDon.Font.FontFamily, 9);
        }

        private void btn_BanHang_MouseEnter(object sender, EventArgs e)
        {
            btn_BanHang.Font = new Font(btn_BanHang.Font.FontFamily, 11);
        }

        private void btn_BanHang_MouseLeave(object sender, EventArgs e)
        {
            btn_BanHang.Font = new Font(btn_BanHang.Font.FontFamily, 9);
        }

        private void btn_ThongKe_MouseEnter(object sender, EventArgs e)
        {
            btn_ThongKe.Font = new Font(btn_ThongKe.Font.FontFamily, 11);
        }

        private void btn_ThongKe_MouseLeave(object sender, EventArgs e)
        {
            btn_ThongKe.Font = new Font(btn_ThongKe.Font.FontFamily, 9);
        }

        private void btn_VaiTro_MouseEnter(object sender, EventArgs e)
        {
            btn_VaiTro.Font = new Font(btn_VaiTro.Font.FontFamily, 11);
        }

        private void btn_VaiTro_MouseLeave(object sender, EventArgs e)
        {
            btn_VaiTro.Font = new Font(btn_VaiTro.Font.FontFamily, 9);
        }

        private void btn_KhuyenMai_MouseEnter(object sender, EventArgs e)
        {
            btn_KhuyenMai.Font = new Font(btn_KhuyenMai.Font.FontFamily, 11);
        }

        private void btn_KhuyenMai_MouseLeave(object sender, EventArgs e)
        {
            btn_KhuyenMai.Font = new Font(btn_KhuyenMai.Font.FontFamily, 9);
        }

        private void btn_DangXuat_MouseEnter(object sender, EventArgs e)
        {
            btn_DangXuat.Font = new Font(btn_DangXuat.Font.FontFamily, 11);
        }

        private void btn_DangXuat_MouseLeave(object sender, EventArgs e)
        {
            btn_DangXuat.Font = new Font(btn_DangXuat.Font.FontFamily, 9);
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
        }

    }
}
