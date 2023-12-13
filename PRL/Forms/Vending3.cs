using BUS.IServices;
using BUS.Services;
using BUS.Utilites;
using DAL.Model;
using Microsoft.IdentityModel.Tokens;
using PRL.VIewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
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
        ICustomersSV _customersv;
        IBillSV _Billsv;
        IDetailBillSV _DetaiBill;
        Guid _idWhenClickCTSP;
        Guid _idWhenClickSP;
        Guid _idWhenClickCart;
        Guid _idWhenClickWaitingbill;
        public static string TenKhachhang;
        public static string SDTKhachhang;
        public static List<Cart> _Lstgiohang = new List<Cart>();
        public Nhanvien NhanvienInVending = new Nhanvien();
        public static decimal Tongtienphaithanhtoan;
        public static decimal Tongtiendagiam;
        public static decimal Tienkhachtra;
        public static decimal Tientralai;
        public Hoadon _Hoadon;
        public Hoadonchitiet _Hoadonchitiet;
        public static string SaleDangdung;

        public Vending3()
        {
            _colorsv = new ColorSV();
            _materialsv = new MaterialSV();
            _sizesv = new SizeSv();
            _detailproductsv = new DetailPRoductsSV();
            _producsv = new ProductsSV();
            _picturesv = new PictureSV();
            _salesv = new SaleSV();
            _customersv = new CustomersSV();
            _Billsv = new BillSV();
            _DetaiBill = new DetailBillSV();
            InitializeComponent();
            LoadGrid(null);
            LoadKM();
            dtg_Cart.ScrollBars = ScrollBars.Both;
            txt_ID.Visible = false;
            LoadGridWaitingBill(_Billsv.Getlistofunpaidinvoices());
            _idWhenClickWaitingbill = Guid.Empty;
            _Lstgiohang.Clear();

        }

        //===============TÀI NGUYÊN CHO FORM BILL===================
        public string GetTenKH()
        {
            return txt_KhachHang.Text;
        }
        public string GetSDT_KH()
        {
            return txt_SDT.Text;
        }

        public List<Cart> GetCarts()
        {
            return _Lstgiohang;
        }
        //==========================================================




        public string GetTenSanpham(Guid input)//truyen vao id chitietsanpham
        {
            //tim ten san pham de them vao gio hang
            var tensp = _producsv.Findbyid(_detailproductsv.GetAll1(null).FirstOrDefault(c => c.Id == input).Idsanpham).Ten;
            return tensp;
        }
        public string Getkichthuoc(Guid input)//truyen vao id chitietsanpham
        {
            //tim size de them vao gio hang
            var size = _sizesv.FindNamebyID(ProductValidate.convertGUID(_detailproductsv.GetAll1(null).FirstOrDefault(c => c.Id == input).Idkichthuoc));
            return size;
        }
        public string GetChatLieu(Guid input)//truyen vao id chitietsanpham
        {
            //tim chat lieu de them vao gio hang
            var chatlieu = _materialsv.FindNamebyID(ProductValidate.convertGUID(_detailproductsv.GetAll1(null).FirstOrDefault(c => c.Id == input).Idchatlieu));
            return chatlieu;
        }
        public string GetMauSac(Guid input)//truyen vao id chitietsanpham
        {
            //tim chat lieu de them vao gio hang
            var mausac = _colorsv.FindNamebyID(ProductValidate.convertGUID(_detailproductsv.GetAll1(null).FirstOrDefault(c => c.Id == input).Idmauao));
            return mausac;
        }

        public void LoadKM()
        {
            foreach (var s in _salesv.GetKM())
            {
                if (s.Trangthai == "Hoạt động")
                {
                    cmb_Sale.Items.Add(s.Tenmakhuyenmai);
                }
            }
            cmb_Sale.SelectedIndex = 1;
            cmb_Sale.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void LoadGrid(string input)
        {


            int stt = 1;
            Dtg_LstProduct.ColumnCount = 9;
            Dtg_LstProduct.Columns[0].Name = "STT";
            Dtg_LstProduct.Columns[1].Name = "ID";
            //Dtg_LstProduct.Columns[1].Visible = false;
            Dtg_LstProduct.Columns[2].Name = "Tên";
            Dtg_LstProduct.Columns[3].Name = "Số lượng";
            Dtg_LstProduct.Columns[4].Name = "Màu";
            Dtg_LstProduct.Columns[5].Name = "Kích thước";
            Dtg_LstProduct.Columns[6].Name = "Chất liệu";
            Dtg_LstProduct.Columns[7].Name = "Mô tả";
            Dtg_LstProduct.Columns[8].Name = "ID Ảnh";
            Dtg_LstProduct.Rows.Clear();
            Dtg_LstProduct.AllowUserToAddRows = false;
            foreach (var sp in _detailproductsv.GetLstSpConHang())
            {

                Dtg_LstProduct.Rows.Add(stt++, sp.Id, _producsv.Findbyid(sp.Idsanpham).Ten, sp.Soluongton, _colorsv.FindNamebyID(_colorsv.convertGUID(sp.Idmauao)), _sizesv.FindNamebyID(_sizesv.convertGUID(sp.Idkichthuoc)), _materialsv.FindNamebyID(_materialsv.convertGUID(sp.Idchatlieu)), sp.Mota, sp.IdAnh);
            }

        }

        public void LoadDTGCart(List<Cart> lstcart)
        {
            decimal tmpgia = 0;
            int stt = 1;
            dtg_Cart.ColumnCount = 8;
            dtg_Cart.Columns[0].Name = "STT";
            dtg_Cart.Columns[1].Name = "ID";
            dtg_Cart.Columns[1].Visible = false;
            dtg_Cart.Columns[2].Name = "Tên sản phẩm";
            dtg_Cart.Columns[3].Name = "Số lượng mua";
            dtg_Cart.Columns[4].Name = "Màu sắc";
            dtg_Cart.Columns[5].Name = "Chất liệu";
            dtg_Cart.Columns[6].Name = "Size";
            dtg_Cart.Columns[7].Name = "Giá";
            dtg_Cart.Rows.Clear();
            dtg_Cart.AllowUserToAddRows = false;
            foreach (var sp in lstcart)
            {

                dtg_Cart.Rows.Add(stt++, sp.Id, sp.TenSp, sp.Soluongmua, sp.Mausac, sp.Chatlieu, sp.Size, sp.GiaTongSanPhamMua);
            }

            for (int i = 0; i < lstcart.Count; i++)
            {
                tmpgia += lstcart[i].GiaTongSanPhamMua;
            }
            lb_Tong.Text = tmpgia.ToString();
            if (string.IsNullOrEmpty(cmb_Sale.Text))
            {
                lb_Totalaftersale.Text = lb_Tong.Text;
            }
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
            txt_ID.Text = ProductValidate.convertGUID(CTSP.Id).ToString();
            txt_Tong.Text = txt_Gia.Text;


        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {

            //Nếu txtsoluong null
            if (string.IsNullOrEmpty(txt_SoLuong.Text))
            {
                txt_Tong.Text = txt_Gia.Text;

            }
            //Check số âm
            else if (!ProductValidate.CheckIfNegativeValue(txt_SoLuong.Text))
            {
                MessageBox.Show("Can't be negative value!");
                txt_SoLuong.Text = null;
                return;
            }
            //Check phải là số
            else if (!ProductValidate.IsNumeric(txt_SoLuong.Text))
            {
                MessageBox.Show("Can't fill the letters!", "Inform");
                txt_SoLuong.Text = null;
                return;
            }
            else if (string.IsNullOrEmpty(txt_ID.Text))
            {
                MessageBox.Show("You need to select a product!", "Inform");
                txt_SoLuong.Text = null; return;
            }
            else
            {
                txt_Tong.Text = (int.Parse(txt_SoLuong.Text) * decimal.Parse(txt_Gia.Text)).ToString();

            }




        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_SoLuong.Text))
            {
                MessageBox.Show("You need to fill the quantity!", "Inform"); return;
            }
            else
            {
                //CHECK KHI CHƯA CHỌN SẢN PHẨM MÀ ĐÃ BẤM ADD
                if (!string.IsNullOrEmpty(txt_ID.Text))
                {
                    if (!(_idWhenClickWaitingbill == Guid.Empty)) //Thêm sản phẩm mới vào WAITING BILL
                    {
                        //check số lượng mua nhỏ hơn số lượng tốn
                        var ctsp = _detailproductsv.GetAll(null).FirstOrDefault(c => c.Id.ToString() == txt_ID.Text);
                        if (int.Parse(txt_SoLuong.Text) > ctsp.Soluongton)
                        {
                            MessageBox.Show("The product in stock has only " + ctsp.Soluongton + " items left, please enter a quantity to purchase that is less than the available stock.");
                            txt_SoLuong.Text = null;
                            return;
                        }

                        //Thêm sản phẩm mới vào trong hóa đơn chờ
                        var findHD = _Billsv.GetHoadons(null).FirstOrDefault(c => c.Id == _idWhenClickWaitingbill);
                        if (findHD != null)
                        {
                            //lấy ra tất cả hóa đơn chi tiết trong hóa đơn chờ
                            var lstHDCT = _DetaiBill.GetAllHoaDonChiTiet().Where(c => c.Idhoadon == findHD.Id).ToList();
                            //tìm ra thằng hóa đơn chi tiết có idctsp trùng với idctsp cần thêm(nếu có trùng thì cộng dồn 
                            var HDCTTrung = lstHDCT.FirstOrDefault(c => c.Idchitietsanpham == Guid.Parse(txt_ID.Text));



                            if (HDCTTrung != null) // Nếu trùng thì cộng dồn
                            {
                                var carttmp = _Lstgiohang.FirstOrDefault(c => c.IdSanpham == HDCTTrung.Idchitietsanpham);
                                //tìm ra thằng số lượng tồn của thằng sản phẩm trong kho hàng
                                var slton = _detailproductsv.GetAll(null).FirstOrDefault(c => c.Id == HDCTTrung.Idchitietsanpham).Soluongton;
                                var slmuanew = HDCTTrung.Soluong + int.Parse(txt_SoLuong.Text);
                                if (slton >= slmuanew)
                                {
                                    HDCTTrung.Soluong = slmuanew;
                                    HDCTTrung.Giaban = HDCTTrung.Giaban + decimal.Parse(txt_Tong.Text);
                                    carttmp.Soluongmua = slmuanew;
                                    carttmp.GiaTongSanPhamMua = HDCTTrung.Giaban;
                                    LoadDTGCart(_Lstgiohang);
                                    LoadGridWaitingBill(_Billsv.Getlistofunpaidinvoices());

                                }
                                else
                                {
                                    MessageBox.Show("The product in stock has only " + ctsp.Soluongton + " items left, please enter a quantity to purchase that is less than the available stock.");
                                    return;
                                }
                            }
                            else // nếu không trùng thì add sp mới cho hd chờ
                            {
                                Hoadonchitiet hdctnew = new()
                                {
                                    Id = Guid.NewGuid(),
                                    Soluong = int.Parse(txt_SoLuong.Text),
                                    Giaban = decimal.Parse(txt_Tong.Text),
                                    Idhoadon = _idWhenClickWaitingbill,
                                    Idchitietsanpham = _idWhenClickCTSP,
                                };
                                Cart cartnew = new()
                                {
                                    Id = Guid.NewGuid(),
                                    Soluongmua = int.Parse(txt_SoLuong.Text),
                                    GiaTongSanPhamMua = decimal.Parse(txt_Tong.Text),
                                    TenSp = txt_name.Text,
                                    IdSanpham = _idWhenClickCTSP,
                                    Mausac = GetMauSac(_idWhenClickCTSP),
                                    Chatlieu = GetChatLieu(_idWhenClickCTSP),
                                    Size = Getkichthuoc(_idWhenClickCTSP)

                                };
                                _Lstgiohang.Add(cartnew);
                                _DetaiBill.AddDetailBill(hdctnew);
                                LoadDTGCart(_Lstgiohang);
                            }

                        }
                    }
                    else //THÊM SẢN PHẨM MỚI VÀO GIỎ HÀNG BTH
                    {
                        //check số lượng mua nhỏ hơn số lượng tốn
                        var ctsp = _detailproductsv.GetAll(null).FirstOrDefault(c => c.Id.ToString() == txt_ID.Text);
                        if (int.Parse(txt_SoLuong.Text) > ctsp.Soluongton)
                        {
                            MessageBox.Show("The product in stock has only " + ctsp.Soluongton + " items left, please enter a quantity to purchase that is less than the available stock.");
                            txt_SoLuong.Text = null;
                            return;
                        }


                        var tmp = _Lstgiohang.FirstOrDefault(c => c.IdSanpham.ToString() == txt_ID.Text);

                        //Nếu trong giỏ hàng không có sản phẩm nào giống nhau cần cộng dồn.=> tạo cart mới
                        if (tmp == null)
                        {
                            var cart = new Cart()
                            {
                                Id = Guid.NewGuid(),

                                IdSanpham = Guid.Parse(txt_ID.Text),
                                TenSp = GetTenSanpham(Guid.Parse(txt_ID.Text)),
                                Soluongmua = int.Parse(txt_SoLuong.Text),
                                Mausac = GetMauSac(Guid.Parse(txt_ID.Text)),
                                Size = Getkichthuoc(Guid.Parse(txt_ID.Text)),
                                Chatlieu = GetChatLieu(Guid.Parse(txt_ID.Text)),
                                GiaTongSanPhamMua = int.Parse(txt_SoLuong.Text) * decimal.Parse(txt_Gia.Text),
                            };
                            _idWhenClickCart = cart.Id;
                            _Lstgiohang.Add(cart);
                            LoadDTGCart(_Lstgiohang);
                        }

                        //nếu trong giỏ hàng có sản phẩm giống nhau cần cộng dồn, => lấy cart cũ + dồn số lượng mua lên.
                        else
                        {

                            var slmuanew = tmp.Soluongmua + int.Parse(txt_SoLuong.Text);
                            if (ctsp.Soluongton >= slmuanew)
                            {
                                tmp.Soluongmua = slmuanew;
                                tmp.GiaTongSanPhamMua = tmp.GiaTongSanPhamMua + decimal.Parse(txt_Tong.Text);
                                LoadDTGCart(_Lstgiohang);
                            }
                            else
                            {
                                MessageBox.Show("The product in stock has only " + ctsp.Soluongton + " items left, please enter a quantity to purchase that is less than the available stock.");
                                return;
                            }
                        }
                    }
                    decimal tongtien = 0;
                    for (int i = 0; i < _Lstgiohang.Count; i++)
                    {
                        tongtien += _Lstgiohang[i].GiaTongSanPhamMua;
                        LoadDTGCart(_Lstgiohang);
                    }
                    lb_Tong.Text = tongtien.ToString();
                    lb_Totalaftersale.Text = (tongtien - (tongtien * _salesv.GetDiscountByName(cmb_Sale.Text) / 100)).ToString();
                }
                else
                {
                    MessageBox.Show("You need to select a product!", "Inform"); return;
                }
            }



        }


        public void ClearForm()
        {
            _idWhenClickWaitingbill = Guid.Empty;
            dataGridView1.ClearSelection();
            //cmb_Sale.Text = null;
            txt_SoLuong.Text = null;
            txt_name.Text = null;
            txt_ID.Text = null;
            txt_KhachHang.Text = null;
            txt_Gia.Text = null;
            txt_SDT.Text = null;
            txt_Tong.Text = null;
            lb_Totalaftersale.Text = 0.ToString();
            lb_Tong.Text = 0.ToString();
            lb_TienThua.Text = 0.ToString();
            txt_CashReceived.Text = null;
            Picturebox_Product.Image = Image.FromFile("D:\\Da1_5\\GIT\\BanQuanAo_Da1\\PRL\\IMG\\default-thumbnail.jpg");
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_CashReceived.Text = null;
            lb_TienThua.Text = 0.ToString();
            txt_KhachHang.Enabled = true;
            txt_SDT.Enabled = true;
            _Lstgiohang.Clear();
            LoadDTGCart(_Lstgiohang);
            cmb_Sale.SelectedIndex = 1;
            ClearForm();
        }

        private void dtg_Cart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            //lấy id từ dòng đang bấm kết hợp cell
            if (rowindex == -1)
            {
                return;
            }
            //
            //_idWhenClickCTSP = Guid.Parse(Dtg_LstProduct.Rows[rowindex].Cells[1].Value.ToString()
            _idWhenClickCart = Guid.Parse(dtg_Cart.Rows[rowindex].Cells[1].Value.ToString());
            var cart = _Lstgiohang.FirstOrDefault(c => c.Id == _idWhenClickCart);
            var giactsp = _detailproductsv.GetAll1(null).FirstOrDefault(c => c.Id == cart.IdSanpham).Giaban;
            txt_name.Text = cart.TenSp;
            txt_Gia.Text = giactsp.ToString();
            txt_SoLuong.Text = cart.Soluongmua.ToString();

            Image tmp = _detailproductsv.GetImageByPath(cart.IdSanpham);
            Picturebox_Product.Image = tmp;
            txt_ID.Text = ProductValidate.convertGUID(cart.IdSanpham).ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if(_idWhenClickWaitingbill == Guid.Empty)
            {
                //CHECK KHI CHƯA CHỌN SẢN PHẨM MÀ ĐÃ BẤM UPDATE
                if (!string.IsNullOrEmpty(txt_ID.Text))
                {
                    _idWhenClickCTSP = Guid.Parse(txt_ID.Text);
                    var tmp = _Lstgiohang.FirstOrDefault(c => c.IdSanpham == _idWhenClickCTSP);
                    if (!string.IsNullOrEmpty(txt_SoLuong.Text))
                    {
                        var ctsptmp = _detailproductsv.GetAll(null).FirstOrDefault(c => c.Id == Guid.Parse(txt_ID.Text));
                        if (ctsptmp.Soluongton < int.Parse(txt_SoLuong.Text))
                        {
                            //Lỗi số lượng mua nhiều hơn số lượng tồn
                            MessageBox.Show("The product in stock has only " + ctsptmp.Soluongton + " items left, please enter a quantity to purchase that is less than the available stock.");
                            txt_SoLuong.Text = null;
                            return;
                        }
                        else if (string.IsNullOrEmpty(txt_SoLuong.Text))
                        {
                            MessageBox.Show("This field can't be null", "Inform"); return;
                        }
                        else
                        {
                            tmp.Soluongmua = int.Parse(txt_SoLuong.Text);
                            tmp.GiaTongSanPhamMua = int.Parse(txt_SoLuong.Text) * decimal.Parse(txt_Gia.Text);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Quantity fields can't be empty!", "Inform");
                        return;
                    }
                    //tmp.GiaTongSanPhamMua += decimal.Parse(txt_Tong.Text);
                    LoadDTGCart(_Lstgiohang);
                }
                else
                {
                    MessageBox.Show("You need to select a product!", "Inform"); return;
                }
                ClearForm();
            }
            else // Xóa trong hóa đơn chờ
            {
                if(!string.IsNullOrEmpty(txt_SoLuong.Text))
                {
                    if (txt_SoLuong.Text == "0")
                    {
                        MessageBox.Show("Quantity can't be zero!", "Inform"); return;

                    }

                    else
                    {
                        //check số lượng mua nhỏ hơn số lượng tốn
                        var ctsp1 = _detailproductsv.GetAll(null).FirstOrDefault(c => c.Id.ToString() == txt_ID.Text);
                        if (int.Parse(txt_SoLuong.Text) > ctsp1.Soluongton)
                        {
                            MessageBox.Show("The product in stock has only " + ctsp1.Soluongton + " items left, please enter a quantity to purchase that is less than the available stock.");
                            txt_SoLuong.Text = null;
                            return;
                        }
                        //lấy ra 1 thằng hóa đơn chờ cellclick
                        var hdcho = _Billsv.GetHoadons(null).FirstOrDefault(c => c.Id == _idWhenClickWaitingbill);

                        //Lấy ra 1 thằng cart cellclick => lấy idctsp
                        var cartcellclick = _Lstgiohang.FirstOrDefault(c => c.Id == _idWhenClickCart);

                        //lấy ra 1 thằng ctsp có cùng idctsp với thằng cart đang click
                        var ctsp = _detailproductsv.GetAll1(null).FirstOrDefault(c => c.Id == cartcellclick.IdSanpham);

                        //Lấy ra 1 list các cthd có cùng id với thằng hdcho ở trên
                        var lstcthd = _DetaiBill.GetAllHoaDonChiTiet().Where(c => c.Idhoadon == hdcho.Id);

                        //Update trong gio hang
                        var tmp = _Lstgiohang.FirstOrDefault(c => c.IdSanpham == Guid.Parse(txt_ID.Text));
                        tmp.Soluongmua = int.Parse(txt_SoLuong.Text);
                        tmp.GiaTongSanPhamMua = tmp.Soluongmua * ctsp.Giaban;


                        //Update trong db
                        //Trong lstcthd, tìm 1 thằng cthd có cùng idsp với thằng cart đang click
                        var cthdfordelete = lstcthd.FirstOrDefault(c => c.Idchitietsanpham == cartcellclick.IdSanpham);
                        cthdfordelete.Giaban = tmp.GiaTongSanPhamMua;
                        cthdfordelete.Soluong = tmp.Soluongmua;

                        _DetaiBill.Update(cthdfordelete); // Update trong db

                        //ClearForm();
                        LoadDTGCart(_Lstgiohang);
                        LoadGridWaitingBill(_Billsv.Getlistofunpaidinvoices());
                    }
                }
                else
                {
                    MessageBox.Show("Quantity is not null", "Inform");return;
                }

            }
        }


        //KHI CHỌN KHUYẾN MÃI, TIỀN SẼ TỰ TRỪ
        private void cmb_Sale_SelectedIndexChanged(object sender, EventArgs e)
        {



            decimal sotiengiam = decimal.Parse(lb_Tong.Text) * _salesv.GetDiscountByName(cmb_Sale.Text) / 100;
            lb_Totalaftersale.Text = (decimal.Parse(lb_Tong.Text) - sotiengiam).ToString();

        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            //<*> 2 trường hợp LỚN: 1.là thanh toán chậm theo hóa đơn chờ, 2. là thanh toán nhanh.

            //~~~~~~~~~~~~~TH1: THANH TOÁN THEO HÓA ĐƠN CHỜ~~~~~~~~~~~~~~~~~~~~~~~~~~~
            if (_idWhenClickWaitingbill != Guid.Empty)
            {
                //2. PHẢI ĐIỀN SDT KHÁCH HÀNG
                if (string.IsNullOrEmpty(txt_SDT.Text))
                {
                    MessageBox.Show("You need to fill customer's phone numbers before add this bill!", "Inform"); return;
                }
                //4. PHẢI ĐIỀN TÊN KHÁCH HÀNG
                if (string.IsNullOrEmpty(txt_KhachHang.Text))
                {
                    MessageBox.Show("You need to fill customer's name before add this bill!", "Inform"); return;
                }
                //5. Nếu ô tiền khách trả bị null
                if (string.IsNullOrEmpty(txt_CashReceived.Text))
                {
                    MessageBox.Show("Cash received from customer can't be null!", "Inform"); return;
                }
                //6. Nếu ô tiền khách trả <= 0
                if (decimal.Parse(txt_CashReceived.Text) <= 0)
                {
                    MessageBox.Show("Cash received from customer can't be less than 0", "Inform");
                    return;
                }
                //7. Nếu tiền khách trả nhỏ hơn tiền hàng
                if (decimal.Parse(lb_TienThua.Text) < 0)
                {
                    MessageBox.Show("Received money must be greater than or equal to the amount to be paid by the customer.", "Inform");
                    return;
                }
                //8. Trường hợp 1 khách hàng đặt hóa đơn chờ trước, nhưng hàng trong kho đã hết

                //get lst tat ca sp het hang trong kho
                //lst to
                var lsttmp = _detailproductsv.GetLstSpHetHang().Select(c => c.Id).ToList(); // lst idctsp het hang

                // =>idcthd =>idchitietsp co trong hoa don khach hang mua
                //lst nho
                var cthd = _DetaiBill.GetAllHoaDonChiTiet().Where(c => c.Idhoadon == _idWhenClickWaitingbill).Select(c => c.Idchitietsanpham).ToList(); //lst id ctsp khach hang mua

                //lấy được 1 lst idctsp mà khách  hàng mua nhưng trong kho đã hết hàng
                var commonElements = lsttmp.Where(item => cthd.Contains(item)).ToList();
                var hdcho = _DetaiBill.GetAllHoaDonChiTiet().Where(c => c.Idhoadon == _idWhenClickWaitingbill);
                if (commonElements.Count == 0)  //KHI TẤT CẢ SẢN PHẨM TRONG KHO ĐỀU > ĐƠN ĐẶT HÀNG
                {
                    //    //nếu số lượng hàng đặt mua > số lượng tồn
                    List<string> lstten1 = new();
                    foreach (var x in cthd)
                    {
                        var slton = _detailproductsv.GetAll(null).FirstOrDefault(c => c.Id == x).Soluongton;
                        var slmua = hdcho.FirstOrDefault(c => c.Idchitietsanpham == x).Soluong;
                        if (slmua > slton)
                        {
                            lstten1.Add(_detailproductsv.GetTenSP(x));


                        }
                    }
                    if (lstten1.Count > 0)
                    {
                        MessageBox.Show(string.Join(", ", lstten1) + " isn't enough to sell!", "Inform"); return;
                    }
                    //Khi check hết tiến hành thanh toán
                    var FindBill = _Billsv.GetHoadons(null).FirstOrDefault(c => c.Id == _idWhenClickWaitingbill);
                    //Có thể update được cả mã khuyến mãi

                    FindBill.Idkhuyenmai = _salesv.GetidKhuyenMaiByName(cmb_Sale.Text);

                    FindBill.Trangthai = "Đã thanh toán";
                    var option = MessageBox.Show("Are you sure you want to proceed with the payment for this order?", "Notification", MessageBoxButtons.YesNo);
                    if (option == DialogResult.Yes)
                    {
                        Tongtienphaithanhtoan = decimal.Parse(lb_Totalaftersale.Text);
                        Tienkhachtra = decimal.Parse(txt_CashReceived.Text);
                        Tientralai = decimal.Parse(txt_CashReceived.Text) - decimal.Parse(lb_Totalaftersale.Text);
                        SaleDangdung = cmb_Sale.Text;
                        /*ar sale = decimal.Parse(lb_Tong.Text) * _salesv.GetDiscountByName(cmb_Sale.Text) / 100;*/
                        Tongtiendagiam = decimal.Parse(lb_Tong.Text) - decimal.Parse(lb_Totalaftersale.Text);
                        foreach (var hdct in _Lstgiohang)
                        {
                            //KHI ẤN CHECK OUT NÀY THÌ SẢN PHẨM TRONG DATA SẼ TỰ BỊ TRỪ.
                            var chitietsanpham = _detailproductsv.GetAll(null).FirstOrDefault(c => c.Id == hdct.IdSanpham);
                            chitietsanpham.Soluongton -= hdct.Soluongmua;
                            if (chitietsanpham.Soluongton == 0)
                            {
                                chitietsanpham.Trangthai = "Hết hàng";
                            }
                            _detailproductsv.Update(chitietsanpham);
                        }

                        //Nếu đồng ý thì mới sửa bill
                        _Billsv.UpdateBill(FindBill);

                        //gán thông tin cho form hóa đơn load ra
                        Tienkhachtra = decimal.Parse(txt_CashReceived.Text);
                        Tientralai = decimal.Parse(lb_TienThua.Text);
                        Tongtiendagiam = decimal.Parse(lb_Tong.Text) - decimal.Parse(lb_Totalaftersale.Text);
                        SaleDangdung = cmb_Sale.Text;

                        Tongtienphaithanhtoan = decimal.Parse(lb_Totalaftersale.Text);

                        //Mở form thanh toán bill
                        using (Bill_Forms form2 = new Bill_Forms())
                        {
                            form2.ShowDialog();
                        }


                        //load lại dtg
                        LoadGrid(null);
                        _Lstgiohang.Clear();
                        LoadDTGCart(_Lstgiohang);
                        LoadGridWaitingBill(_Billsv.Getlistofunpaidinvoices());
                        ClearForm();
                    }


                    else
                    {
                        //không đồng ý thì return không sửa bill
                        return;
                    }
                    cmb_Sale.SelectedIndex = 1;
                }



                else
                {
                    List<string> lstten = new List<string>();
                    foreach (var x in commonElements)
                    {
                        lstten.Add(_detailproductsv.GetTenSP(x));
                    };
                    MessageBox.Show(string.Join(", ", lstten) + " you have ordered are currently out of stock. Please check back later.", "Inform");
                    ClearForm();
                    return;

                }

            }


            //~~~~~~~~~~~~~~~~~~TH2: THANH TOÁN NHANH~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            else
            {
                // <*> CHECK CÁC LỖI CÓ THỂ XẢY RA

                //1. Check giỏ hàng bị null
                if (_Lstgiohang.Count == 0)
                {
                    MessageBox.Show("This cart being null, can't add waiting bill!", "Inform"); return;
                }
                //2. PHẢI ĐIỀN SDT KHÁCH HÀNG
                if (string.IsNullOrEmpty(txt_SDT.Text))
                {
                    MessageBox.Show("You need to fill customer's phone numbers before add this bill!", "Inform"); return;
                }
                //3. Check định dạng số điện thoại
                if (!ProductValidate.CheckSDT(txt_SDT.Text))
                {
                    MessageBox.Show("This phone number isn't in the correct format!", "Inform");
                    txt_SDT.Text = null;
                    txt_KhachHang.Text = null;
                    return;
                }
                //4. PHẢI ĐIỀN TÊN KHÁCH HÀNG
                if (string.IsNullOrEmpty(txt_KhachHang.Text))
                {
                    MessageBox.Show("You need to fill customer's name before add this bill!", "Inform"); return;
                }
                //5. Nếu ô tiền khách trả bị null
                if (string.IsNullOrEmpty(txt_CashReceived.Text))
                {
                    MessageBox.Show("Cash received from customer can't be null!", "Inform"); return;
                }
                //6. Nếu ô tiền khách trả <= 0
                if (decimal.Parse(txt_CashReceived.Text) <= 0)
                {
                    MessageBox.Show("Cash received from customer can't be less than 0", "Inform");
                    return;
                }
                //7. Nếu tiền khách trả nhỏ hơn tiền hàng
                if (decimal.Parse(lb_TienThua.Text) < 0)
                {
                    MessageBox.Show("Received money must be greater than or equal to the amount to be paid by the customer.", "Inform");
                    return;
                }
                else
                {
                    var option = MessageBox.Show("Are you sure you want to proceed with the payment for this order?", "Notification", MessageBoxButtons.YesNo);
                    if (option == DialogResult.Yes)
                    {
                        Tongtienphaithanhtoan = decimal.Parse(lb_Totalaftersale.Text);
                        Tienkhachtra = decimal.Parse(txt_CashReceived.Text);
                        Tientralai = decimal.Parse(txt_CashReceived.Text) - decimal.Parse(lb_Totalaftersale.Text);
                        SaleDangdung = cmb_Sale.Text;

                        Tongtiendagiam = decimal.Parse(lb_Tong.Text) - decimal.Parse(lb_Totalaftersale.Text);


                        //add khach hang
                        var customernew = new Khachhang()
                        {
                            Id = Guid.NewGuid(),
                            Ten = txt_KhachHang.Text,
                            Sdt = txt_SDT.Text
                        };

                        //NẾU LÀ KHÁCH HÀNG MỚI THÌ SẼ ADD 
                        if (_customersv.ChecktrungSDTKH(txt_SDT.Text))
                        {
                            _customersv.Add(customernew);

                        }

                        //GÁN VÀO BIẾN TENKHACHHANG ĐỂ BINDING SANG FORM HÓA ĐƠN
                        TenKhachhang = txt_KhachHang.Text;

                        //add hoa don
                        using (login lg = new login())
                        {
                            var idnhanvientmp = Guid.Empty;
                            if(Main.account == null)
                            {
                                idnhanvientmp = MainNV1.account.Id;
                            }
                            else
                            {
                                idnhanvientmp = Main.account.Id;
                            }
                            _Hoadon = new Hoadon
                            {
                                Id = Guid.NewGuid(),
                                Ngaytao = DateTime.Now,
                                Idnhanvien = idnhanvientmp,
                                Trangthai = "Đã thanh toán",
                            };

                            //Nếu mà sdt khách hàng tồn tại rồi thì tự động điền idkhachhang vào hóa đơn
                            if (!string.IsNullOrEmpty(customernew.Id.ToString()))
                            {
                                _Hoadon.Idkhachhang = _customersv.GetIDBYSDT(txt_SDT.Text);
                            }

                            _Hoadon.Idkhuyenmai = _salesv.GetidKhuyenMaiByName(cmb_Sale.Text);

                            _Billsv.AddBill(_Hoadon);
                        }

                        //CHẠY VÒNG FOREACH ADD TỪNG CHI TIẾT HÓA ĐƠN.
                        foreach (var hdct in _Lstgiohang)
                        {
                            Hoadonchitiet hdctnew = new Hoadonchitiet()
                            {
                                Id = Guid.NewGuid(),
                                Soluong = hdct.Soluongmua,
                                Giaban = hdct.GiaTongSanPhamMua,
                                Idhoadon = _Hoadon.Id,
                                Idchitietsanpham = hdct.IdSanpham
                            };
                            //KHI ẤN CHECK OUT NÀY THÌ SẢN PHẨM TRONG DATA SẼ TỰ BỊ TRỪ.
                            var chitietsanpham = _detailproductsv.GetAll(null).FirstOrDefault(c => c.Id == hdct.IdSanpham);
                            chitietsanpham.Soluongton -= hdctnew.Soluong;
                            if (chitietsanpham.Soluongton == 0)
                            {
                                chitietsanpham.Trangthai = "Hết hàng";
                            }
                            _detailproductsv.Update(chitietsanpham);
                            _DetaiBill.AddDetailBill(hdctnew);
                        }
                        //gán thông tin cho form hóa đơn load ra
                        Tienkhachtra = decimal.Parse(txt_CashReceived.Text);
                        Tientralai = decimal.Parse(lb_TienThua.Text);
                        Tongtiendagiam = decimal.Parse(lb_Tong.Text) - decimal.Parse(lb_Totalaftersale.Text);

                        SaleDangdung = cmb_Sale.Text;

                        Tongtienphaithanhtoan = decimal.Parse(lb_Totalaftersale.Text);
                        //Mở form thanh toán bill
                        using (Bill_Forms form2 = new Bill_Forms())
                        {
                            form2.ShowDialog();
                        }
                        _Lstgiohang.Clear();
                        LoadDTGCart(_Lstgiohang);
                        LoadGrid(null);
                        ClearForm();
                    }

                }
            }
        }

        private void txt_CashReceived_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_CashReceived.Text))
            {
                lb_TienThua.Text = "0";
            }
            else
            {
                if (lb_Totalaftersale.Text == "0")
                {
                    lb_TienThua.Text = (decimal.Parse(txt_CashReceived.Text) - decimal.Parse(lb_Tong.Text)).ToString();
                    if (string.IsNullOrEmpty(txt_CashReceived.Text))
                    {
                        return;
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(txt_CashReceived.Text))
                    {
                        return;
                    }
                    else if (!ProductValidate.CheckIfContainLetter(txt_CashReceived.Text))
                    {
                        MessageBox.Show("This field doesn't allow letter!", "Inform");
                        return;
                    }
                    else if (ProductValidate.CheckIfContainSymbol(txt_CashReceived.Text))
                    {
                        MessageBox.Show("This field doesn't allow symbol!", "Inform");
                        return;
                    }
                    else
                    {
                        lb_TienThua.Text = (decimal.Parse(txt_CashReceived.Text) - decimal.Parse(lb_Totalaftersale.Text)).ToString();

                    };
                }
            }
        }

        private void txt_SDT_Leave(object sender, EventArgs e)
        {
            var khtmp = _customersv.GetTenBySDt(txt_SDT.Text);
            if (khtmp != null)
            {
                txt_KhachHang.Text = khtmp;
            }
            else
            {
                return;
            }
        }

        private void txt_SoLuong_Leave(object sender, EventArgs e)
        {
            //không có gì
            if (string.IsNullOrEmpty(txt_ID.Text))
            {
                MessageBox.Show("You need to select a product!", "Inform", MessageBoxButtons.OK);
                txt_SoLuong.Text = null;
                return;
            }
            //check null cho textbox số lượng mua % check không có kí tự chữ
            if (ProductValidate.CheckEmptyString(txt_SoLuong.Text))
            {
                if (ProductValidate.IsNumeric(txt_SoLuong.Text))
                {
                    string tmp = txt_Gia.Text;

                    txt_Tong.Text = (int.Parse(txt_SoLuong.Text) * decimal.Parse(tmp)).ToString();

                }
                else
                {
                    MessageBox.Show("Prices or quantity can't contain letters");
                    return;
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (_idWhenClickWaitingbill == Guid.Empty) // Chỉ xóa ở giỏ hàng
            {
                var tmp = _Lstgiohang.FirstOrDefault(c => c.IdSanpham == Guid.Parse(txt_ID.Text));
                _Lstgiohang.Remove(tmp);
                LoadDTGCart(_Lstgiohang);
                ClearForm();
            }
            else // Xóa trong hóa đơn chờ
            {
                //lấy ra 1 thằng hóa đơn chờ cellclick
                var hdcho = _Billsv.GetHoadons(null).FirstOrDefault(c => c.Id == _idWhenClickWaitingbill);

                //Lấy ra 1 thằng cart cellclick => lấy idctsp
                var cartcellclick = _Lstgiohang.FirstOrDefault(c => c.Id == _idWhenClickCart);

                //lấy ra 1 thằng ctsp có cùng idctsp với thằng cart đang click
                var ctsp = _detailproductsv.GetAll1(null).FirstOrDefault(c => c.Id == cartcellclick.IdSanpham);

                //Lấy ra 1 list các cthd có cùng id với thằng hdcho ở trên
                var lstcthd = _DetaiBill.GetAllHoaDonChiTiet().Where(c => c.Idhoadon == hdcho.Id);

                //Update trong gio hang
                var tmp = _Lstgiohang.FirstOrDefault(c => c.IdSanpham == Guid.Parse(txt_ID.Text));
                tmp.GiaTongSanPhamMua = cartcellclick.GiaTongSanPhamMua - ctsp.Giaban;
                tmp.Soluongmua = tmp.Soluongmua - 1;


                //Update trong db
                //Trong lstcthd, tìm 1 thằng cthd có cùng idsp với thằng cart đang click
                var cthdfordelete = lstcthd.FirstOrDefault(c => c.Idchitietsanpham == cartcellclick.IdSanpham);
                cthdfordelete.Giaban = tmp.GiaTongSanPhamMua;
                cthdfordelete.Soluong = tmp.Soluongmua;

                _DetaiBill.Update(cthdfordelete); // Update trong db

                //ClearForm();
                LoadDTGCart(_Lstgiohang);
                LoadGridWaitingBill(_Billsv.Getlistofunpaidinvoices());
            }
        }




        private void Vending3_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            _Lstgiohang.Clear();
        }

        private void btn_AddWaitingBill_Click(object sender, EventArgs e)
        {

            //PHẢI ĐIỀN SDT KHÁCH HÀNG
            if (string.IsNullOrEmpty(txt_SDT.Text))
            {
                MessageBox.Show("You need to fill customer's phone numbers before add this bill!", "Inform"); return;
            }
            if (!ProductValidate.CheckSDT(txt_SDT.Text))
            {
                //check format
                MessageBox.Show("This phone number isn't in the correct format!", "Inform");
                txt_SDT.Text = null;
                txt_KhachHang.Text = null;
                return;
            }
            //PHẢI ĐIỀN TÊN KHÁCH HÀNG
            else if (string.IsNullOrEmpty(txt_KhachHang.Text))
            {
                MessageBox.Show("You need to fill customer's name before add this bill!", "Inform"); return;
            }
            //CHECK XEM GIỎ HÀNG CÓ BỊ NULL KHÔNG
            else if (_Lstgiohang.Count == 0)
            {
                MessageBox.Show("This cart being null, can't add waiting bill!", "Inform"); return;
            }
            else
            {
                var confirm = MessageBox.Show("Are you sure add a new waiting bill?", "Inform", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    //add khach hang
                    var customernew = new Khachhang()
                    {
                        Id = Guid.NewGuid(),
                        Ten = txt_KhachHang.Text,
                        Sdt = txt_SDT.Text
                    };
                    //NẾU LÀ KHÁCH HÀNG MỚI THÌ SẼ ADD 
                    if (_customersv.ChecktrungSDTKH(txt_SDT.Text))
                    {
                        _customersv.Add(customernew);

                    }

                    //GÁN VÀO BIẾN TENKHACHHANG ĐỂ BINDING SANG FORM HÓA ĐƠN
                    TenKhachhang = txt_KhachHang.Text;

                    //add hoa don
                    using (login lg = new login())
                    {
                        _Hoadon = new Hoadon
                        {
                            Id = Guid.NewGuid(),
                            Ngaytao = DateTime.Now,
                            Idnhanvien = Main.account.Id,
                            Trangthai = "Chưa thanh toán",
                        };
                        //Nếu mà sdt khách hàng tồn tại rồi thì tự động điền idkhachhang vào hóa đơn
                        if (!string.IsNullOrEmpty(customernew.Id.ToString()))
                        {
                            _Hoadon.Idkhachhang = _customersv.GetIDBYSDT(txt_SDT.Text);
                        }

                        _Hoadon.Idkhuyenmai = _salesv.GetidKhuyenMaiByName(cmb_Sale.Text);

                        _Billsv.AddBill(_Hoadon);

                        //ADD HDCT
                        foreach (var hdct in _Lstgiohang)
                        {
                            Hoadonchitiet hdctnew = new Hoadonchitiet()
                            {
                                Id = Guid.NewGuid(),
                                Soluong = hdct.Soluongmua,
                                Giaban = hdct.GiaTongSanPhamMua,
                                Idhoadon = _Hoadon.Id,
                                Idchitietsanpham = hdct.IdSanpham
                            };
                            _DetaiBill.AddDetailBill(hdctnew);

                        }

                        LoadGridWaitingBill(_Billsv.Getlistofunpaidinvoices());
                        _Lstgiohang.Clear();
                        LoadDTGCart(_Lstgiohang);
                        ClearForm();
                    }
                }
                else
                {

                    return;
                }
            }
        }


        public void LoadGridWaitingBill(List<Hoadon> LstWaiting)
        {
            int stt = 1;
            dtg_Waitingbill.ColumnCount = 7;
            dtg_Waitingbill.Rows.Clear();
            dtg_Waitingbill.Columns[0].Name = "STT";
            dtg_Waitingbill.Columns[1].Name = "ID";
            dtg_Waitingbill.Columns[1].Visible = false;
            dtg_Waitingbill.Columns[2].Name = "Ngày tạo";
            dtg_Waitingbill.Columns[3].Name = "Tên khách hàng";
            dtg_Waitingbill.Columns[4].Name = "Số điện thoại khách hàng";
            dtg_Waitingbill.Columns[5].Name = "Khuyến mại đang dùng";
            dtg_Waitingbill.Columns[6].Name = "Trạng thái";
            foreach (var sp in LstWaiting)
            {
                if (string.IsNullOrEmpty(sp.Idkhuyenmai.ToString()))
                {
                    dtg_Waitingbill.Rows.Add(stt++, sp.Id, sp.Ngaytao, _customersv.GetTenBYId(sp.Idkhachhang), _customersv.GetAll().FirstOrDefault(c => c.Id == sp.Idkhachhang).Sdt, "Không dùng khuyến mại", sp.Trangthai);
                }
                else
                {
                    dtg_Waitingbill.Rows.Add(stt++, sp.Id, sp.Ngaytao, _customersv.GetTenBYId(sp.Idkhachhang), _customersv.GetAll().FirstOrDefault(c => c.Id == sp.Idkhachhang).Sdt, _salesv.GetTenById(ProductValidate.convertGUID(sp.Idkhuyenmai)), sp.Trangthai);
                }

            }

        }

        private void dtg_Waitingbill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _Lstgiohang.Clear();
            txt_KhachHang.Enabled = false;
            txt_SDT.Enabled = false;
            int rowindex = e.RowIndex;
            //lấy id từ dòng đang bấm kết hợp cell
            if (rowindex == -1)
            {
                return;
            }
            _idWhenClickWaitingbill = Guid.Parse(dtg_Waitingbill.Rows[rowindex].Cells[1].Value.ToString());
            var billchuathanhtoan = _Billsv.GetHoadons(null).FirstOrDefault(c => c.Id == _idWhenClickWaitingbill);
            txt_KhachHang.Text = _customersv.GetTenBYId(billchuathanhtoan.Idkhachhang);
            txt_SDT.Text = _customersv.GetAll().FirstOrDefault(c => c.Id == billchuathanhtoan.Idkhachhang).Sdt;
            cmb_Sale.SelectedIndex = _salesv.GetKM().FindIndex(c => c.Id == billchuathanhtoan.Idkhuyenmai);
            decimal tongtien = 0;
            //Tìm 1 list các hóa đơn chi tiết có cùng 1 id hóa đơn
            List<Hoadonchitiet> lsttmp = _DetaiBill.GetAllHoaDonChiTiet().Where(c => c.Idhoadon == _idWhenClickWaitingbill).ToList();
            ////tính tổng tiền của tất cả hóa đơn đó
            for (int i = 0; i < lsttmp.Count; i++)
            {
                //load lai ve gio hang
                var cartnew = new Cart()
                {
                    Id = Guid.NewGuid(),
                    IdSanpham = lsttmp[i].Idchitietsanpham,
                    TenSp = _detailproductsv.GetTenSP(lsttmp[i].Idchitietsanpham),
                    GiaTongSanPhamMua = lsttmp[i].Giaban,
                    Soluongmua = lsttmp[i].Soluong,
                    Mausac = _DetaiBill.GetMauAo(lsttmp[i].Idchitietsanpham),
                    Size = _DetaiBill.GetSize(lsttmp[i].Idchitietsanpham),
                    Chatlieu = _DetaiBill.GetChatLieu(lsttmp[i].Idchitietsanpham)
                };
                _Lstgiohang.Add(cartnew);
                tongtien += lsttmp[i].Giaban;
                LoadDTGCart(_Lstgiohang);
            }
            lb_Tong.Text = tongtien.ToString();



            lb_Totalaftersale.Text = (tongtien - (tongtien * _salesv.GetDiscountByName(cmb_Sale.Text) / 100)).ToString();




        }

        private void dtg_Waitingbill_Leave(object sender, EventArgs e)
        {

        }

        private void txt_SoLuong_TextChanged_1(object sender, EventArgs e)
        {
            if (!ProductValidate.CheckIfContainLetter(txt_SoLuong.Text))
            {
                MessageBox.Show("Only numbers are allowed here", "Inform");
                ClearForm();
                return;
            }
            if (!string.IsNullOrEmpty(txt_SoLuong.Text))
            {
                txt_Tong.Text = (int.Parse(txt_SoLuong.Text) * decimal.Parse(txt_Gia.Text)).ToString();
            }

            else
            {
                txt_Tong.Text = txt_Gia.Text;
            }
        }
    }
}

