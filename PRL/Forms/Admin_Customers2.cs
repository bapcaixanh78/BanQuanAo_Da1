using BUS.Services;
using DAL.Model;
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
    public partial class Admin_Customers2 : Form
    {
        private CustomersSV customersSV = new CustomersSV();

        public Admin_Customers2()
        {
            InitializeComponent();
            customersSV = new CustomersSV();

        }
        public Admin_Customers2(CustomersSV customersSV)
        {
            this.customersSV = customersSV;
        }

        public void LoadDataToGridview(List<Khachhang> khachhangs)
        {
            int stt = 1;

            dtg_KhachHang.ColumnCount = 4;
            dtg_KhachHang.Columns[0].Name = "STT";
            dtg_KhachHang.Columns[1].Name = "ID";
            dtg_KhachHang.Columns[2].Name = "Tên";
            dtg_KhachHang.Columns[3].Name = "SĐT";
            dtg_KhachHang.Rows.Clear();//Clear dữ liệu trước khi tìm kiếm
            dtg_KhachHang.Columns[1].Visible = false;
            dtg_KhachHang.AllowUserToAddRows = false;

            foreach (var item in khachhangs)
            {
                dtg_KhachHang.Rows.Add(stt++, item.Id, item.Ten, item.Sdt);
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            List<Khachhang> KH = customersSV.GetKH(txt_Search.Text);
            LoadDataToGridview(KH);
        }
    }
}
