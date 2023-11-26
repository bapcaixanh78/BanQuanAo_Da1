using BUS.IServices;
using BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Forms
{
    public partial class Admin_Products : Form
    {
        IColorSV _colorsv; 
        IMaterialSV _materialsv; 
        IDetailProductsSV _detailproductsv; 
        ISizeSV _sizesv; 
        IProductsSV _producsv; 
        public Admin_Products()
        {
            _colorsv = new ColorSV();
            _materialsv = new MaterialSV();
            _detailproductsv = new DetailPRoductsSV();
            _sizesv = new SizeSv();
            _producsv = new ProductsSV();
            InitializeComponent();
            LoadComboBox();
            LoadGrid(null);
        }

        public void LoadComboBox()
        {
            foreach (var s in _colorsv.GetMauaos())
            {
                cmb_Color.Items.Add(s.Mau);
            }
            cmb_Color.SelectedIndex = 0;
            cmb_Color.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var s in _materialsv.GetChatlieus())
            {
                cmb_Material.Items.Add(s.Ten);
            }
            cmb_Material.SelectedIndex = 0;
            cmb_Material.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var s in _sizesv.GetKichthuocs())
            {
                cmb_Size.Items.Add(s.Size);
            }
            cmb_Size.SelectedIndex = 0;
            cmb_Size.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void LoadGrid(string input)
        {
            int stt = 1;
            dtg_SanPham.ColumnCount = 10;
            dtg_SanPham.Columns[0].Name = "STT";
            dtg_SanPham.Columns[1].Name = "ID";
            dtg_SanPham.Columns[1].Visible = false;
            dtg_SanPham.Columns[2].Name = "Tên";
            dtg_SanPham.Columns[3].Name = "Giá nhập";
            dtg_SanPham.Columns[4].Name = "Giá bán";
            dtg_SanPham.Columns[5].Name = "Số lượng";
            dtg_SanPham.Columns[6].Name = "Màu";
            dtg_SanPham.Columns[7].Name = "Kích thước";
            dtg_SanPham.Columns[8].Name = "Chất liệu";
            dtg_SanPham.Columns[9].Name = "Mô tả";
            dtg_SanPham.Rows.Clear();

            foreach (var sp in _detailproductsv.GetAll1())
            {
                dtg_SanPham.Rows.Add(stt++,sp.Id, _producsv.Findbyid(sp.Idsanpham).Ten, sp.Gianhap, sp.Giaban, sp.Soluongton, sp.Idmauao, sp.Idkichthuoc, sp.Idchatlieu, sp.Mota);
            }
        }
    }
}
