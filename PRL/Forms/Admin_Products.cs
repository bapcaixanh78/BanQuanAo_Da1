using BUS.IServices;
using BUS.Services;
using DAL.Model;
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
using static Microsoft.FSharp.Core.ByRefKinds;

namespace PRL.Forms
{
    public partial class Admin_Products : Form
    {
        IColorSV _colorsv;
        IMaterialSV _materialsv;
        IDetailProductsSV _detailproductsv;
        IPictureSV _picturesv;
        ISizeSV _sizesv;
        IProductsSV _producsv;
        Guid _idWhenClickCTSP;
        Guid _idWhenClickSP;
        public Admin_Products()
        {
            _colorsv = new ColorSV();
            _materialsv = new MaterialSV();
            _detailproductsv = new DetailPRoductsSV();
            _sizesv = new SizeSv();
            _producsv = new ProductsSV();
            _picturesv = new PictureSV();
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
            dtg_SanPham.ColumnCount = 11;
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
            dtg_SanPham.Columns[10].Name = "ID Ảnh";
            dtg_SanPham.Rows.Clear();
            dtg_SanPham.AllowUserToAddRows = false;
            foreach (var sp in _detailproductsv.GetAll1(txt_TimKiemSP.Text))
            {

                dtg_SanPham.Rows.Add(stt++, sp.Id, _producsv.Findbyid(sp.Idsanpham).Ten, sp.Gianhap, sp.Giaban, sp.Soluongton, _colorsv.FindNamebyID(_colorsv.convertGUID(sp.Idmauao)), _sizesv.FindNamebyID(_sizesv.convertGUID(sp.Idkichthuoc)), _materialsv.FindNamebyID(_materialsv.convertGUID(sp.Idchatlieu)), sp.Mota,sp.IdAnh);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var CTSP = new Chitietsanpham();
            var SP = new Sanpham()
            {
                Id = Guid.NewGuid(),
                Ten = txtTenHang.Text,

            };
            var Img = new Anh()
            {
                Idanh = Guid.NewGuid(),
                Ten = "Ảnh áo phông",
                Path = txt_ImgPath.Text,
            };





            CTSP.IdAnh = Img.Idanh;
            CTSP.Gianhap = decimal.Parse(txtGiaNhap.Text);
            CTSP.Ngaytao = DateTime.Now;
            CTSP.Ngaycapnhat = DateTime.Now;
            CTSP.Giaban = decimal.Parse(txtGiaBan.Text);
            CTSP.Soluongton = int.Parse(txt_SoLuong.Text);
            if (int.Parse(txt_SoLuong.Text) > 0)
            {
                CTSP.Trangthai = ("Còn hàng");
            }
            CTSP.Idsanpham = SP.Id;
            CTSP.Idmauao = _colorsv.FindIDbyName(cmb_Color.SelectedItem.ToString());
            CTSP.Idchatlieu = _materialsv.FindIDbyName(cmb_Material.SelectedItem.ToString());
            CTSP.Idkichthuoc = _sizesv.FindIDbyName(cmb_Size.SelectedItem.ToString());
            CTSP.Mota = rtxt_MoTa.Text;
            var option = MessageBox.Show("Confirm", "Notification", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                _picturesv.AddImg(Img);
                _producsv.Add(SP);
                MessageBox.Show(_detailproductsv.Add(CTSP));




            }
            else
            {
                return;
            }
            LoadGrid(null);

        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            var CTSP = _detailproductsv.GetAll1(null).FirstOrDefault(x => x.Id == _idWhenClickCTSP);
            var SP = _producsv.GetSP(null).FirstOrDefault(x => x.Id == _idWhenClickSP);
            var img = _picturesv.Getall().FirstOrDefault(c => c.Idanh == CTSP.IdAnh);

            CTSP.Id = _idWhenClickCTSP;
            SP.Id = _idWhenClickSP;

            var option = MessageBox.Show("Xác nhận muốn Xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                _detailproductsv.Delete(CTSP);
                MessageBox.Show(_producsv.Delete(SP));
                _picturesv.DeleteImg(img.Idanh);

            }
            else
            {
                return;
            }
            LoadGrid(null);
        }


        private void dtg_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            //lấy id từ dòng đang bấm kết hợp cell
            if (rowindex == -1)
            {
                return;
            }
            _idWhenClickCTSP = Guid.Parse(dtg_SanPham.Rows[rowindex].Cells[1].Value.ToString());
            _idWhenClickSP = _producsv.FindIDbyName(dtg_SanPham.Rows[rowindex].Cells[2].Value.ToString());
            var CTSP = _detailproductsv.GetAll1(null).FirstOrDefault(x => x.Id == _idWhenClickCTSP);
            var SP = _producsv.GetSP(null).FirstOrDefault(x => x.Id == _idWhenClickSP);
            txtTenHang.Text = SP.Ten;
            txtGiaNhap.Text = CTSP.Gianhap.ToString();
            txtGiaBan.Text = CTSP.Giaban.ToString();
            cmb_Color.SelectedIndex = _colorsv.GetMauaos().FindIndex(t => t.Id == CTSP.Idmauao);
            cmb_Material.SelectedIndex = _materialsv.GetChatlieus().FindIndex(t => t.Id == CTSP.Idchatlieu);
            cmb_Size.SelectedIndex = _sizesv.GetKichthuocs().FindIndex(t => t.Id == CTSP.Idkichthuoc);
            rtxt_MoTa.Text = CTSP.Mota;
            txt_SoLuong.Text = CTSP.Soluongton.ToString();
            txt_ImgPath.Text = _detailproductsv.GetPathImgByIdImg(_detailproductsv.convertGUID(CTSP.IdAnh));
            Image tmp = _detailproductsv.GetImageByPath(CTSP.Id);
            Picturebox_Product.Image = tmp;


        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var CTSP = _detailproductsv.GetAll1(null).FirstOrDefault(x => x.Id == _idWhenClickCTSP);
            var SP = _producsv.GetSP(null).FirstOrDefault(x => x.Id == _idWhenClickSP);
            if (!_picturesv.GetLstPath().Contains(txt_ImgPath.Text))
            {
                var Img = new Anh()
                {
                    Idanh = Guid.NewGuid(),
                    Ten = "Ảnh áo phông",
                    Path = txt_ImgPath.Text,
                };
                _picturesv.AddImg(Img);
            }
            var img = _picturesv.Getall().FirstOrDefault(c => c.Path == txt_ImgPath.Text);

            img.Path = txt_ImgPath.Text;
            SP.Ten = txtTenHang.Text;
            CTSP.IdAnh = _picturesv.FindIdByPath(txt_ImgPath.Text);
            CTSP.Giaban = decimal.Parse(txtGiaBan.Text);
            CTSP.Gianhap = decimal.Parse(txtGiaNhap.Text);
            CTSP.Idmauao = _colorsv.FindIDbyName(cmb_Color.SelectedItem.ToString());
            CTSP.Idchatlieu = _materialsv.FindIDbyName(cmb_Material.SelectedItem.ToString());
            CTSP.Idkichthuoc = _sizesv.FindIDbyName(cmb_Size.SelectedItem.ToString());
            CTSP.Mota = rtxt_MoTa.Text;
            var option = MessageBox.Show("Xác nhận muốn Sửa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                MessageBox.Show(_detailproductsv.Update(CTSP));
                _producsv.Update(SP);
                _picturesv.UpdateImg(img);
            }
            else
            {
                return;
            }
            LoadGrid(null);

        }

        public void LoadGridSP(List<Chitietsanpham> chitietsanphams)
        {
            int stt = 1;
            dtg_SanPham.ColumnCount = 11;
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
            dtg_SanPham.AllowUserToAddRows = false;
            foreach (var sp in chitietsanphams)
            {

                dtg_SanPham.Rows.Add(stt++, sp.Id, _producsv.Findbyid(sp.Idsanpham).Ten, sp.Gianhap, sp.Giaban, sp.Soluongton, _colorsv.FindNamebyID(_colorsv.convertGUID(sp.Idmauao)), _sizesv.FindNamebyID(_sizesv.convertGUID(sp.Idkichthuoc)), _materialsv.FindNamebyID(_materialsv.convertGUID(sp.Idchatlieu)), sp.Mota);
            }
        }
        private void txt_TimKiemSP_TextChanged(object sender, EventArgs e)
        {
            List<Chitietsanpham> chitietsanphams = _detailproductsv.GetAll(null);
            List<Sanpham> sanphams = _producsv.GetSP(null).Where(x=>x.Ten.ToLower().Trim().Contains(txt_TimKiemSP.Text.ToLower())).ToList();

            var overlap = 
                from pd in chitietsanphams
                join sp in sanphams on pd.Idsanpham equals sp.Id
                select pd;
            if (txt_TimKiemSP != null)
            {
                LoadGridSP(overlap.ToList());
            }
            else
            {
                LoadGrid(null);
            }
        }

        private void dtg_SanPham_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtTenHang.Text = null;
            txtGiaNhap.Text = null;
            txtGiaBan.Text = null;
            cmb_Color.SelectedIndex = 0;
            cmb_Material.SelectedIndex = 0;
            cmb_Size.SelectedIndex = 0;
            rtxt_MoTa.Text = null;
            txt_SoLuong.Text = null;
        }

        private void btn_browser_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileOpen = new OpenFileDialog();
                fileOpen.Title = "Open Image file";
                fileOpen.Filter = "Files|*.jpg;*.jpeg;*.png";

                if (fileOpen.ShowDialog() == DialogResult.OK)
                {
                    Picturebox_Product.Image = Image.FromFile(fileOpen.FileName);
                    txt_ImgPath.Text = fileOpen.FileName;
                }
                fileOpen.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
