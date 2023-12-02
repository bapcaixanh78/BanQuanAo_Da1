using BUS.IServices;
using BUS.Services;
using DAL.Model;
using PRL.VIewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Forms
{
    public partial class Vending3 : Form
    {
        IColorSV _colorsv;
        IMaterialSV _materialsv;
        IDetailProductsSV _detailproductsv;
        IPictureSV _picturesv;
        ISizeSV _sizesv;
        IProductsSV _producsv;
        ISaleSV _salesv;
        Guid _idWhenClickCTSP;
        Guid _idWhenClickSP;
        List<Cart> _Lstgiohang;
        public Vending3()
        {
            _colorsv = new ColorSV();
            _materialsv = new MaterialSV();
            _sizesv = new SizeSv();
            _detailproductsv = new DetailPRoductsSV();
            _producsv = new ProductsSV();
            _picturesv = new PictureSV();
            _salesv = new SaleSV();
            _Lstgiohang = new List<Cart>();
            InitializeComponent();
            LoadGrid(null);
            LoadKM();
        }

        public void LoadKM()
        {
            foreach (var s in _salesv.GetKM())
            {
                cmb_Sale.Items.Add(s.Tenmakhuyenmai);
            }
            cmb_Sale.SelectedIndex = 0;
            cmb_Sale.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void LoadGrid(string input)
        {


            int stt = 1;
            Dtg_LstProduct.ColumnCount = 9;
            Dtg_LstProduct.Columns[0].Name = "STT";
            Dtg_LstProduct.Columns[1].Name = "ID";
            Dtg_LstProduct.Columns[1].Visible = false;
            Dtg_LstProduct.Columns[2].Name = "Tên";
            Dtg_LstProduct.Columns[3].Name = "Số lượng";
            Dtg_LstProduct.Columns[4].Name = "Màu";
            Dtg_LstProduct.Columns[5].Name = "Kích thước";
            Dtg_LstProduct.Columns[6].Name = "Chất liệu";
            Dtg_LstProduct.Columns[7].Name = "Mô tả";
            Dtg_LstProduct.Columns[8].Name = "ID Ảnh";
            Dtg_LstProduct.Rows.Clear();
            Dtg_LstProduct.AllowUserToAddRows = false;
            foreach (var sp in _detailproductsv.GetAll1(null))
            {
                if (sp.Trangthai == "Còn hàng")
                {
                    Dtg_LstProduct.Rows.Add(stt++, sp.Id, _producsv.Findbyid(sp.Idsanpham).Ten, sp.Soluongton, _colorsv.FindNamebyID(_colorsv.convertGUID(sp.Idmauao)), _sizesv.FindNamebyID(_sizesv.convertGUID(sp.Idkichthuoc)), _materialsv.FindNamebyID(_materialsv.convertGUID(sp.Idchatlieu)), sp.Mota, sp.IdAnh);
                }
            }
        }

        public void LoadGridSP(List<Hoadonchitiet> hoadonchitiets)
        {
            //int stt = 1;
            //dtg_Cart.ColumnCount = 6;
            //dtg_Cart.Columns[0].Name = "STT";
            //dtg_Cart.Columns[1].Name = "ID";
            //dtg_Cart.Columns[1].Visible = false;
            //dtg_Cart.Columns[2].Name = "Tên sản phẩm";
            //dtg_Cart.Columns[3].Name = "Số lượng";
            //dtg_Cart.Columns[4].Name = "Giá bán";
            //dtg_Cart.Columns[5].Name = "ID sản phẩm";
            //dtg_Cart.Rows.Clear();
            //dtg_Cart.AllowUserToAddRows = false;
            //foreach (var sp in hoadonchitiets)
            //{

            //    dtg_Cart.Rows.Add(stt++, sp.Id,_producsv.Findbyid());
            //}
        }



        private void Dtg_LstProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            //lấy id từ dòng đang bấm kết hợp cell
            if (rowindex == -1)
            {
                return;
            }
            _idWhenClickCTSP = Guid.Parse(Dtg_LstProduct.Rows[rowindex].Cells[1].Value.ToString());
            _idWhenClickSP = _producsv.FindIDbyName(Dtg_LstProduct.Rows[rowindex].Cells[2].Value.ToString());

            var CTSP = _detailproductsv.GetAll1(null).FirstOrDefault(x => x.Id == _idWhenClickCTSP);
            var SP = _producsv.GetSP(null).FirstOrDefault(x => x.Id == _idWhenClickSP);

            txt_name.Text = SP.Ten;
            txt_Gia.Text = CTSP.Giaban.ToString();
            Image tmp = _detailproductsv.GetImageByPath(CTSP.Id);
            Picturebox_Product.Image = tmp;

            //Add cart
            //Cart Crt = new Cart()
            //{
            //    Id = Guid.NewGuid(),
            //    TenSp = txt_name.Text,
            //    Mausac = Dtg_LstProduct.Rows[rowindex].Cells[4].Value.ToString(),
            //     = Dtg_LstProduct.Rows[rowindex].Cells[4].Value.ToString(),
            //    Mausac = Dtg_LstProduct.Rows[rowindex].Cells[4].Value.ToString(),
            //};



        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d+$");
            if (txt_SoLuong.Text != null)
            {
                string tmp = txt_Gia.Text;

                txt_Tong.Text = (int.Parse(txt_SoLuong.Text) * decimal.Parse(tmp)).ToString();
            }
            else if (!regex.IsMatch(txt_SoLuong.Text))
            {
                MessageBox.Show("")
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }
    }
}
