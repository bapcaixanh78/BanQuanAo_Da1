using BUS.IServices;
using BUS.Services;
using DAL.Model;

namespace PRL.Forms
{
    public partial class Revenue_By_Products : Form
    {
        private IDetailProductsSV _DetailProduct;
        private IDetailBillSV _DetailBill;

        public Revenue_By_Products()
        {
            _DetailProduct = new DetailPRoductsSV();
            _DetailBill = new DetailBillSV();
            InitializeComponent();
            loadDtg(_DetailProduct.GetAll1(null));
        }

        private void loadDtg(List<Chitietsanpham> lst)
        {
            int stt = 1;
            dtg_Revenue_By_Products.Rows.Clear();
            dtg_Revenue_By_Products.DataSource = null;
            dtg_Revenue_By_Products.ColumnCount = 5;
            dtg_Revenue_By_Products.Columns[0].Name = "STT";
            dtg_Revenue_By_Products.Columns[1].Name = "ID";
            dtg_Revenue_By_Products.Columns[1].Visible = false;
            dtg_Revenue_By_Products.Columns[2].Name = "Product's name";
            dtg_Revenue_By_Products.Columns[3].Name = "Amount sold";
            dtg_Revenue_By_Products.Columns[4].Name = "Revenue";

            dtg_Revenue_By_Products.AllowUserToAddRows = false;
            foreach (var x in lst)
            {
                dtg_Revenue_By_Products.Rows.Add(stt++, x.Id, _DetailProduct.GetTenSP(x.Id), TongSoLuongBanra(x.Id), TongDoanhThuMangVe(x.Id));
            }
        }

        public int TongSoLuongBanra(Guid idctsp)
        {
            int tongslbanra = 0;

            // lay 1 lst cthd
            var lstcthd = _DetailBill.GetAllHoaDonChiTiet();

            foreach (var x in lstcthd)
            {
                if (x.Idchitietsanpham == idctsp)
                {
                    tongslbanra = tongslbanra + x.Soluong;
                }
            }
            return tongslbanra;
        }

        public decimal TongDoanhThuMangVe(Guid idctsp)
        {
            var lstcthd = _DetailBill.GetAllHoaDonChiTiet();
            decimal tongdoanhthu = 0;
            Chitietsanpham chitietsanpham = _DetailProduct.GetSP(idctsp);
            tongdoanhthu = TongSoLuongBanra(idctsp) * chitietsanpham.Giaban;
            return tongdoanhthu;
        }
    }
}