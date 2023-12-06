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
        Guid _id_Hoa_Don_Khi_Add_SP;
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
                cmb_Sale.Items.Add(s.Tenmakhuyenmai);
            }
            //cmb_Sale.SelectedIndex = 0;
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
            foreach (var sp in _detailproductsv.GetAll1(null))
            {
                if (sp.Trangthai == "Còn hàng")
                {
                    Dtg_LstProduct.Rows.Add(stt++, sp.Id, _producsv.Findbyid(sp.Idsanpham).Ten, sp.Soluongton, _colorsv.FindNamebyID(_colorsv.convertGUID(sp.Idmauao)), _sizesv.FindNamebyID(_sizesv.convertGUID(sp.Idkichthuoc)), _materialsv.FindNamebyID(_materialsv.convertGUID(sp.Idchatlieu)), sp.Mota, sp.IdAnh);
                }
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
            else if(string.IsNullOrEmpty(txt_ID.Text))
            {
                MessageBox.Show("You need to select a product!", "Inform");
                txt_SoLuong.Text = null;return;
            }
            else
            {
                txt_Tong.Text = (int.Parse(txt_SoLuong.Text) * decimal.Parse(txt_Gia.Text)).ToString();

            }




        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_SoLuong.Text))
            {
                MessageBox.Show("You need to fill the quantity!", "Inform");return;
            }
            else
            {
                //CHECK KHI CHƯA CHỌN SẢN PHẨM MÀ ĐÃ BẤM ADD
                if (!string.IsNullOrEmpty(txt_ID.Text))
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
                else
                {
                    MessageBox.Show("You need to select a product!", "Inform"); return;
                }
            }



        }


        public void ClearForm()
        {
            cmb_Sale.Text = null;
            txt_SoLuong.Text = null;
            txt_name.Text = null;
            txt_ID.Text = null;
            txt_KhachHang.Text = null;
            txt_Gia.Text = null;
            txt_SDT.Text = null;
            txt_Tong.Text = null;

            Picturebox_Product.Image = Image.FromFile("D:\\Da1_5\\GIT\\BanQuanAo_Da1\\PRL\\IMG\\default-thumbnail.jpg");
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            _Lstgiohang.Clear();
            LoadDTGCart(_Lstgiohang);
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
            //_idWhenClickCTSP = Guid.Parse(Dtg_LstProduct.Rows[rowindex].Cells[1].Value.ToString());
            _idWhenClickCart = Guid.Parse(dtg_Cart.Rows[rowindex].Cells[1].Value.ToString());
            var cart = _Lstgiohang.FirstOrDefault(c => c.Id == _idWhenClickCart);
            txt_name.Text = cart.TenSp;
            txt_SoLuong.Text = cart.Soluongmua.ToString();
            Image tmp = _detailproductsv.GetImageByPath(cart.IdSanpham);
            Picturebox_Product.Image = tmp;
            txt_ID.Text = ProductValidate.convertGUID(cart.IdSanpham).ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
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
                        MessageBox.Show("The product in stock has only " + ctsptmp.Soluongton + " items left, please enter a quantity to purchase that is less than the available stock.");
                        txt_SoLuong.Text = null;
                        return;
                    }
                    else if (string.IsNullOrEmpty(txt_SoLuong.Text))
                    {

                    }else
                        tmp.Soluongmua = int.Parse(txt_SoLuong.Text);
                }
                else
                {
                    MessageBox.Show("Quantity fields can't be empty!", "Inform");
                    return;
                }
                tmp.GiaTongSanPhamMua += decimal.Parse(txt_Tong.Text);
                LoadDTGCart(_Lstgiohang);
            }
            else
            {
                MessageBox.Show("You need to select a product!", "Inform"); return;
            }
            ClearForm();
        }


        //KHI CHỌN KHUYẾN MÃI, TIỀN SẼ TỰ TRỪ
        private void cmb_Sale_SelectedIndexChanged(object sender, EventArgs e)
        {

            decimal sotiengiam = decimal.Parse(lb_Tong.Text) * _salesv.GetDiscountByName(cmb_Sale.Text) / 100;
            if (cmb_Sale.Text != null)
            {
                lb_Totalaftersale.Text = (decimal.Parse(lb_Tong.Text) - sotiengiam).ToString();
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            //Nếu ô tiền khách trả bị null
            if (!string.IsNullOrEmpty(txt_CashReceived.Text))
            {

                if (lb_Totalaftersale.Text == "0")
                {
                    if (decimal.Parse(txt_CashReceived.Text) <= 0)
                    {
                        //Lỗi tiền khách trả âm

                        MessageBox.Show("This field does not accept negative numbers or zero.", "Inform");
                        return;
                    }
                    else if (decimal.Parse(lb_TienThua.Text) < 0)
                    {
                        //Lỗi tiền khách trả nhỏ hơn tiền hàng(sau khi giảm giá)
                        MessageBox.Show("Received money must be greater than or equal to the amount to be paid by the customer.", "Inform");
                        return;
                    }
                }
                else
                {
                    if (decimal.Parse(txt_CashReceived.Text) <= 0)
                    {
                        //Lỗi tiền khách trả âm
                        MessageBox.Show("This field does not accept negative numbers or zero.", "Inform");
                        return;
                    }
                    else if (decimal.Parse(lb_TienThua.Text) < 0)
                    {
                        //Lỗi tiền khách trả nhỏ hơn tiền hàng(sau khi giảm giá)
                        MessageBox.Show("Received money must be greater than or equal to the amount to be paid by the customer.", "Inform");
                        return;
                    }
                }

                //Nếu thỏa mãn hết cách điều kiện thì add hóa đơn
                if (decimal.Parse(txt_CashReceived.Text) >= decimal.Parse(lb_Totalaftersale.Text))//TIỀN KHÁCH TRẢ LỚN HƠN TIỀN PHẢI TRẢ => TRUE
                {
                    var option = MessageBox.Show("Are you sure you want to proceed with the payment for this order?", "Notification", MessageBoxButtons.YesNo);
                    if (option == DialogResult.Yes)
                    {
                        Tongtienphaithanhtoan = decimal.Parse(lb_Totalaftersale.Text);
                        Tienkhachtra = decimal.Parse(txt_CashReceived.Text);
                        Tientralai = decimal.Parse(txt_CashReceived.Text) - decimal.Parse(lb_Totalaftersale.Text);
                        SaleDangdung = cmb_Sale.Text;
                        if (!string.IsNullOrEmpty(cmb_Sale.Text))
                        {
                            /*ar sale = decimal.Parse(lb_Tong.Text) * _salesv.GetDiscountByName(cmb_Sale.Text) / 100;*/
                            Tongtiendagiam = decimal.Parse(lb_Tong.Text) - decimal.Parse(lb_Totalaftersale.Text);
                        }
                        else
                        {
                            Tongtiendagiam = 0;
                        }

                        if (!ProductValidate.CheckSDT(txt_SDT.Text))
                        {
                            MessageBox.Show("This phone number isn't in the correct format!","Inform");
                            txt_KhachHang.Text = null;
                            return;
                        };

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

                            };
                            //Nếu mà sdt khách hàng tồn tại rồi thì tự động điền idkhachhang vào hóa đơn
                            if (!string.IsNullOrEmpty(customernew.Id.ToString()))
                            {
                                _Hoadon.Idkhachhang = _customersv.GetIDBYSDT(txt_SDT.Text);
                            }
                            //else//nếu 
                            //{
                            //    _Hoadon.Idkhachhang = customernew.Id;
                            //}


                            if (!string.IsNullOrEmpty(cmb_Sale.Text))
                            {
                                _Hoadon.Idkhuyenmai = _salesv.GetidKhuyenMaiByName(cmb_Sale.Text);
                            }
                            else            //NẾU KHÁCH HÀNG KHÔNG DÙNG KHUYẾN MÃI, THÌ Ô ID KHUYẾN MÃI TRONG CTHD SẼ TRỐNG
                            {
                                _Hoadon.Idkhuyenmai = null;
                            }
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


                        if(string.IsNullOrEmpty(txt_SDT.Text) || string.IsNullOrEmpty(txt_KhachHang.Text))
                        {
                            MessageBox.Show("You need do fill customer's name and phone numbers!", "Inform");
                            return;
                        }
                        else
                        {
                            //MỞ FORM BILL
                            using (Bill_Forms form2 = new Bill_Forms())
                            {
                                form2.ShowDialog();
                            }
                            ClearForm();
                            LoadGrid(null);
                            _Lstgiohang.Clear();
                            LoadDTGCart(_Lstgiohang);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("This field does not null here.", "Inform");

                return;
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

        private void txt_SDT_TextChanged(object sender, EventArgs e)
        {

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
            var tmp = _Lstgiohang.FirstOrDefault(c => c.IdSanpham == Guid.Parse(txt_ID.Text));
            _Lstgiohang.Remove(tmp);
            LoadDTGCart(_Lstgiohang);
            ClearForm();
        }
    }
}

