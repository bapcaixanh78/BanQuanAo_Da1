using DAL.Model;
using PRL.VIewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Forms
{
    public partial class Bill_Forms : Form
    {
        public List<Cart> _lstcartinbill;
        public Nhanvien _nhanvien = new Nhanvien();
        public Khachhang _khachhang = new Khachhang();
        public decimal _Tienphaithanhtoan;
        public decimal _TienDagiam;
        public decimal _Tienkhachtra;
        public decimal _Tientralai;
        public Bill_Forms()
        {
            InitializeComponent();
            _lstcartinbill = Vending3._Lstgiohang;
            LoadDTGCart(_lstcartinbill);
        }
        public void LoadDTGCart(List<Cart> lstcart)
        {
            int stt = 1;
            dtg_Bill.ColumnCount = 8;
            dtg_Bill.Columns[0].Name = "STT";
            dtg_Bill.Columns[1].Name = "ID";
            dtg_Bill.Columns[1].Visible = false;
            dtg_Bill.Columns[2].Name = "Tên sản phẩm";
            dtg_Bill.Columns[3].Name = "Số lượng mua";
            dtg_Bill.Columns[4].Name = "Màu sắc";
            dtg_Bill.Columns[5].Name = "Chất liệu";
            dtg_Bill.Columns[6].Name = "Size";
            dtg_Bill.Columns[7].Name = "Giá";
            dtg_Bill.Rows.Clear();
            dtg_Bill.AllowUserToAddRows = false;
            foreach (var sp in lstcart)
            {
                dtg_Bill.Rows.Add(stt++, sp.Id, sp.TenSp, sp.Soluongmua, sp.Mausac, sp.Chatlieu, sp.Size, sp.GiaTongSanPhamMua);
            }

        }
        private void btn_Out_Click(object sender, EventArgs e)
        {
            var tmp = MessageBox.Show("Are you sure close this form?", "Inform", MessageBoxButtons.YesNo);
            if (tmp == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }

        }

        private void Bill_Forms_Load(object sender, EventArgs e)
        {
            _lstcartinbill = Vending3._Lstgiohang;
            _nhanvien = Main.account;
            lb_TienKhachTra.Text = Vending3.Tienkhachtra.ToString();
            lb_TienThua.Text = Vending3.Tientralai.ToString();
            lb_TongTienGiam.Text = Vending3.Tongtiendagiam.ToString();
            lb_TongTienPhaiTra.Text = Vending3.Tongtienphaithanhtoan.ToString();
            lb_NgayBan.Text = DateTime.Now.ToString();
            lb_NguoiBan.Text = _nhanvien.Ten.ToString();
        }
    }
}
