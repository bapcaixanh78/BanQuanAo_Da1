using BUS.IServices;
using BUS.Services;
using BUS.Utilites;
using DAL.Model;
using System.Data;

namespace PRL.Forms
{
    public partial class Admin_Products : Form
    {
        private IColorSV _colorsv;
        private IMaterialSV _materialsv;
        private IDetailProductsSV _detailproductsv;
        private IPictureSV _picturesv;
        private ISizeSV _sizesv;
        private IProductsSV _producsv;
        private IListSV1 _listSV;
        private Guid _idWhenClickCTSP;
        private Guid _idWhenClickSP;

        public Admin_Products()
        {
            _colorsv = new ColorSV();
            _materialsv = new MaterialSV();
            _detailproductsv = new DetailPRoductsSV();
            _sizesv = new SizeSv();
            _listSV = new ListSV1();
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
                cmb_colorFIlter.Items.Add(s.Mau);
            }
            cmb_Color.SelectedIndex = 0;
            cmb_Color.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmb_colorFIlter.SelectedIndex = 0;

            cmb_colorFIlter.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var s in _materialsv.GetChatlieus())
            {
                cmb_Material.Items.Add(s.Ten);
            }
            cmb_Material.SelectedIndex = 0;
            cmb_Material.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var s in _sizesv.GetKichthuocs())
            {
                cmb_Size.Items.Add(s.Size);
                cmb_sizeFilter.Items.Add(s.Size);
            }
            cmb_Size.SelectedIndex = 0;
            cmb_Size.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmb_sizeFilter.SelectedIndex = 0;
            cmb_sizeFilter.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var s in _listSV.GetDanhmucs())
            {
                cmb_list.Items.Add(s.Ten);
            }
            cmb_list.SelectedIndex = 0;
            cmb_list.DropDownStyle = ComboBoxStyle.DropDownList;

            cmb_statusFilter.Items.Add("Còn hàng");
            cmb_statusFilter.Items.Add("Hết hàng");
            //cmb_statusFilter.SelectedIndex = 0;
            cmb_statusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void LoadGrid(string input)
        {
            int stt = 1;
            dtg_SanPham.DataSource = null;
            dtg_SanPham.Rows.Clear();
            dtg_SanPham.ColumnCount = 13;
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
            dtg_SanPham.Columns[9].Name = "Danh mục";
            dtg_SanPham.Columns[10].Name = "Mô tả";
            dtg_SanPham.Columns[11].Name = "Trạng thái";
            dtg_SanPham.Columns[12].Name = "ID Ảnh";
            dtg_SanPham.Columns[12].Visible = false;

            dtg_SanPham.AllowUserToAddRows = false;
            foreach (var sp in _detailproductsv.GetAll1(txt_TimKiemSP.Text))
            {
                dtg_SanPham.Rows.Add(stt++, sp.Id, _producsv.Findbyid(sp.Idsanpham).Ten, sp.Gianhap, sp.Giaban, sp.Soluongton, _colorsv.FindNamebyID(_colorsv.convertGUID(sp.Idmauao)), _sizesv.FindNamebyID(_sizesv.convertGUID(sp.Idkichthuoc)), _materialsv.FindNamebyID(_materialsv.convertGUID(sp.Idchatlieu)), _listSV.FindNamebyID(_listSV.convertGUID(sp.Iddanhmuc)), sp.Mota, sp.Trangthai, sp.IdAnh);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //Kiểm tra chuỗi rỗng
            if (!ProductValidate.CheckEmptyString(txtTenHang.Text) ||
                !ProductValidate.CheckEmptyString(txtGiaNhap.Text) ||
                !ProductValidate.CheckEmptyString(txtGiaBan.Text) ||
                !ProductValidate.CheckEmptyString(txt_SoLuong.Text))

            {
                MessageBox.Show("Please fill all required fields");
                return;
            }

            //Kiểm tra chứa số
            if (!ProductValidate.CheckIfContainNumber(txtTenHang.Text))
            {
                MessageBox.Show("Name can't contain number");
                return;
            }

            //Kiểm tra chứa ký tự
            if (ProductValidate.CheckIfContainSymbol(txtTenHang.Text))
            {
                MessageBox.Show("Name can't contain symbols");
                return;
            }

            //Kiểm tra tên sản phẩm đã tồn tại chưa
            if (ProductValidate.CheckIfProductNameExist(txtTenHang.Text))
            {
                MessageBox.Show("Product name already exist");
                return;
            }

            //Kiểm tra có chứa ký tự
            if (!ProductValidate.CheckIfContainLetter(txtGiaNhap.Text) ||
                !ProductValidate.CheckIfContainLetter(txtGiaBan.Text) ||
                !ProductValidate.CheckIfContainLetter(txt_SoLuong.Text))
            {
                MessageBox.Show("Prices or quantity can't contain letters");
                return;
            }

            //Kiểm tra giá trị âm
            if (!ProductValidate.CheckIfNegativeValue(txtGiaNhap.Text) ||
                !ProductValidate.CheckIfNegativeValue(txtGiaBan.Text) ||
                !ProductValidate.CheckIfNegativeValue(txt_SoLuong.Text))
            {
                MessageBox.Show("Prices or quantity can't be negative values");
                return;
            }

            //Kiểm tra giá nhập lớn hơn giá bán
            if ((decimal.Parse(txtGiaNhap.Text) > decimal.Parse(txtGiaBan.Text)) ||
                (decimal.Parse(txtGiaNhap.Text) == decimal.Parse(txtGiaBan.Text)))
            {
                MessageBox.Show("Entry price can't be greater or equal to selling price");
                return;
            }

            var CTSP = new Chitietsanpham();
            var SP = new Sanpham()
            {
                Id = Guid.NewGuid(),
                Ten = txtTenHang.Text,
            };
            var Img = new Anh()
            {
                Idanh = Guid.NewGuid(),
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
            CTSP.Iddanhmuc = _listSV.FindIDbyName(cmb_list.SelectedItem.ToString());
            CTSP.Mota = rtxt_MoTa.Text;
            var option = MessageBox.Show("Confirm", "Notification", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                _picturesv.AddImg(Img);
                _producsv.Add(SP);
                MessageBox.Show(_detailproductsv.Add(CTSP));
                clear();
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
            cmb_list.SelectedIndex = _listSV.GetDanhmucs().FindIndex(t => t.Id == CTSP.Iddanhmuc);
            rtxt_MoTa.Text = CTSP.Mota;
            txt_SoLuong.Text = CTSP.Soluongton.ToString();

            txt_ImgPath.Text = _detailproductsv.GetPathImgByIdImg(_detailproductsv.convertGUID(CTSP.IdAnh));
            Image tmp = _detailproductsv.GetImageByPath(CTSP.Id);
            Picturebox_Product.Image = tmp;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Kiểm tra chuỗi rỗng
            if (!ProductValidate.CheckEmptyString(txtTenHang.Text) ||
                !ProductValidate.CheckEmptyString(txtGiaNhap.Text) ||
                !ProductValidate.CheckEmptyString(txtGiaBan.Text) ||
                !ProductValidate.CheckEmptyString(txt_SoLuong.Text))

            {
                MessageBox.Show("Please fill all required fields");
                return;
            }

            //Kiểm tra chứa số
            if (!ProductValidate.CheckIfContainNumber(txtTenHang.Text))
            {
                MessageBox.Show("Name can't contain number");
                return;
            }

            //Kiểm tra chứa ký tự
            if (ProductValidate.CheckIfContainSymbol(txtTenHang.Text))
            {
                MessageBox.Show("Name can't contain symbols");
                return;
            }

            //Kiểm tra tên đã tồn tại không tính tên ban đầu
            if (ProductValidate.CheckIfProductNameExistUpdate(dtg_SanPham.CurrentRow.Cells[2].Value.ToString(), txtTenHang.Text))
            {
                MessageBox.Show("Product's name already exist");
                return;
            }

            //Kiểm tra chứa ký tự
            if (!ProductValidate.CheckIfContainLetter(txtGiaNhap.Text) ||
                !ProductValidate.CheckIfContainLetter(txtGiaBan.Text) ||
                !ProductValidate.CheckIfContainLetter(txt_SoLuong.Text))
            {
                MessageBox.Show("Prices or quantity can't contain letters");
                return;
            }

            //Kiểm tra giá trị âm
            if (!ProductValidate.CheckIfNegativeValue(txtGiaNhap.Text) ||
                !ProductValidate.CheckIfNegativeValue(txtGiaBan.Text) ||
                !ProductValidate.CheckIfNegativeValue(txt_SoLuong.Text))
            {
                MessageBox.Show("Prices or quantity can't be negative values");
                return;
            }

            //Check giá nhập lớn hơn giá bán
            if ((decimal.Parse(txtGiaNhap.Text) > decimal.Parse(txtGiaBan.Text)) ||
                (decimal.Parse(txtGiaNhap.Text) == decimal.Parse(txtGiaBan.Text)))
            {
                MessageBox.Show("Entry price can't be greater or equal to selling price");
                return;
            }

            if(txt_SoLuong.Text == "0")
            {
                MessageBox.Show("Quantity can't be zero");
                return;
            }

            try
            {
                var CTSP = _detailproductsv.GetAll1(null).FirstOrDefault(x => x.Id == _idWhenClickCTSP);
                var SP = _producsv.GetSP(null).FirstOrDefault(x => x.Id == _idWhenClickSP);
                var img = _picturesv.Getall().FirstOrDefault(c => c.Path == txt_ImgPath.Text);
                if (img == null)
                {
                    var ImgNew = new Anh()
                    {
                        Idanh = Guid.NewGuid(),
                        Path = txt_ImgPath.Text,
                    };
                    _picturesv.AddImg(ImgNew);
                }

                var tmpImg = _picturesv.Getall().FirstOrDefault(c => c.Path == txt_ImgPath.Text);

                tmpImg.Path = txt_ImgPath.Text;
                SP.Ten = txtTenHang.Text;
                CTSP.IdAnh = _picturesv.FindIdByPath(txt_ImgPath.Text);
                CTSP.Giaban = decimal.Parse(txtGiaBan.Text);
                CTSP.Gianhap = decimal.Parse(txtGiaNhap.Text);
                CTSP.Soluongton = int.Parse(txt_SoLuong.Text);
                if(CTSP.Soluongton > 0)
                {
                    CTSP.Trangthai = "Còn hàng";
                }
                CTSP.Idmauao = _colorsv.FindIDbyName(cmb_Color.SelectedItem.ToString());
                CTSP.Idchatlieu = _materialsv.FindIDbyName(cmb_Material.SelectedItem.ToString());
                CTSP.Idkichthuoc = _sizesv.FindIDbyName(cmb_Size.SelectedItem.ToString());
                CTSP.Iddanhmuc = _listSV.FindIDbyName(cmb_list.SelectedItem.ToString());
                CTSP.Mota = rtxt_MoTa.Text;
                var option = MessageBox.Show("Confirm", "Notification", MessageBoxButtons.YesNo);
                if (option == DialogResult.Yes)
                {
                    MessageBox.Show(_detailproductsv.Update(CTSP));
                    _producsv.Update(SP);
                    _picturesv.UpdateImg(tmpImg);
                    clear();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                clear();
                return;
            }
            finally
            {
                List<Chitietsanpham> chitietsanphams = _detailproductsv.GetAll1(null);
                LoadGridSP(chitietsanphams);
            }
            
        }

        public void LoadGridSP(List<Chitietsanpham> chitietsanphams)
        {
            int stt = 1;
            dtg_SanPham.ColumnCount = 13;
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
            dtg_SanPham.Columns[9].Name = "Danh mục";
            dtg_SanPham.Columns[10].Name = "Mô tả";
            dtg_SanPham.Columns[11].Name = "Trạng thái";
            dtg_SanPham.Columns[12].Name = "ID Ảnh";
            dtg_SanPham.Columns[12].Visible = false;
            dtg_SanPham.Rows.Clear();
            dtg_SanPham.AllowUserToAddRows = false;

            foreach (var sp in chitietsanphams)
            {
                dtg_SanPham.Rows.Add(stt++, sp.Id, _producsv.Findbyid(sp.Idsanpham).Ten, sp.Gianhap, sp.Giaban, sp.Soluongton, _colorsv.FindNamebyID(_colorsv.convertGUID(sp.Idmauao)), _sizesv.FindNamebyID(_sizesv.convertGUID(sp.Idkichthuoc)), _materialsv.FindNamebyID(_materialsv.convertGUID(sp.Idchatlieu)), _listSV.FindNamebyID(_listSV.convertGUID(sp.Iddanhmuc)), sp.Mota, sp.Trangthai, sp.IdAnh);
            }
        }

        private void txt_TimKiemSP_TextChanged(object sender, EventArgs e)
        {
            List<Chitietsanpham> chitietsanphams = _detailproductsv.GetAll(null);
            List<Sanpham> sanphams = _producsv.GetSP(null).Where(x => x.Ten.ToLower().Trim().Contains(txt_TimKiemSP.Text.ToLower())).ToList();

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

        public void clear()
        {
            txtTenHang.Text = null;
            txtGiaNhap.Text = null;
            txtGiaBan.Text = null;
            cmb_Color.SelectedIndex = 0;
            cmb_Material.SelectedIndex = 0;
            cmb_Size.SelectedIndex = 0;
            cmb_list.SelectedIndex = 0;
            rtxt_MoTa.Text = null;
            txt_SoLuong.Text = null;
            txt_ImgPath.Text = null;
            Picturebox_Product.Image = Image.FromFile("D:\\Da1_5\\GIT\\BanQuanAo_Da1\\PRL\\IMG\\default-thumbnail.jpg");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            var lst = _detailproductsv.GetAll(null);
            clear();
            LoadGridSP(lst);
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

        private void btn_filter_Click(object sender, EventArgs e)
        {
            Guid? sizeFilter = string.IsNullOrEmpty(cmb_sizeFilter.Text) ? (Guid?)null : _sizesv.FindIDbyName(cmb_sizeFilter.Text);
            Guid? colorFilter = string.IsNullOrEmpty(cmb_colorFIlter.Text) ? (Guid?)null : _colorsv.FindIDbyName(cmb_colorFIlter.Text);
            var statusFilter = string.IsNullOrEmpty(cmb_statusFilter.Text) ? null : cmb_statusFilter.Text;

            List<Chitietsanpham> chitietsanphams = _detailproductsv.GetAll(null)
    .Where(x => (sizeFilter == null || x.Idkichthuoc == sizeFilter) &&
                (colorFilter == null || x.Idmauao == colorFilter))
    .ToList();
            string selectedStatus = cmb_statusFilter.SelectedItem.ToString(); // Get the selected status from the ComboBox

            if (selectedStatus == "Còn hàng")
            {
                chitietsanphams = chitietsanphams.Where(sp => sp.Trangthai == "Còn hàng").ToList();
            }
            else if (selectedStatus == "Hết hàng")
            {
                chitietsanphams = chitietsanphams.Where(sp => sp.Trangthai == "Hết hàng").ToList();
            }
            else
            {
                // Handle the case where no status is selected or the selected status is not recognized
                chitietsanphams = chitietsanphams; // Show all products if no status filter is applied
            }

            LoadGridSP(chitietsanphams);
        }
    }
}