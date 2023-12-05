using BUS.IServices;
using BUS.Services;
using PRL.VIewModel;
using System;
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
    public partial class Admin_Bill : Form
    {
        public IBillSV _billsv;
        public IDetailBillSV _Detailbillsv;
        public Admin_Bill()
        {
            _billsv = new BillSV();
            _Detailbillsv = new DetailBillSV();
            InitializeComponent();
        }

        //public void LoadDTGCart(List<> lstcart)
        //{
        //    decimal tmpgia = 0;
        //    int stt = 1;
        //    dtg_SanPham.ColumnCount = 8;
        //    dtg_SanPham.Columns[0].Name = "STT";
        //    dtg_SanPham.Columns[1].Name = "ID";
        //    dtg_SanPham.Columns[1].Visible = false;
        //    dtg_SanPham.Columns[2].Name = "Tên sản phẩm";
        //    dtg_SanPham.Columns[3].Name = "Số lượng mua";
        //    dtg_SanPham.Columns[4].Name = "Màu sắc";
        //    dtg_SanPham.Columns[5].Name = "Chất liệu";
        //    dtg_SanPham.Columns[6].Name = "Size";
        //    dtg_SanPham.Columns[7].Name = "Giá";
        //    dtg_SanPham.Rows.Clear();
        //    dtg_SanPham.AllowUserToAddRows = false;
        //    foreach (var sp in lstcart)
        //    {

        //        dtg_SanPham.Rows.Add(stt++, sp.Id, sp.TenSp, sp.Soluongmua, sp.Mausac, sp.Chatlieu, sp.Size, sp.GiaTongSanPhamMua);
        //    }

        //    for (int i = 0; i < lstcart.Count; i++)
        //    {
        //        tmpgia += lstcart[i].GiaTongSanPhamMua;
        //    }
        //    lb_Tong.Text = tmpgia.ToString();
        //    if (string.IsNullOrEmpty(cmb_Sale.Text))
        //    {
        //        lb_Totalaftersale.Text = lb_Tong.Text;
        //    }
        //}
    }
}
