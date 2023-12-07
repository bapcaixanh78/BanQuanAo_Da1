using BUS.IServices;
using BUS.Services;
using BUS.Utilites;
using PdfSharp.Charting;
using PdfSharp.Drawing;
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
        public IStaffSV _Staffsv;
        public ICustomersSV _Customersv;
        public ISaleSV _saleSV;
        public IStaffSV _staffsv;
        private DataTable dataTable;
        public static List<HoadonViewModel> _lstBill = new List<HoadonViewModel>();
        public Admin_Bill()
        {
            _staffsv = new StaffSV();
            _saleSV = new SaleSV();
            _Customersv = new CustomersSV();
            _Staffsv = new StaffSV();
            _billsv = new BillSV();
            _Detailbillsv = new DetailBillSV();
            InitializeComponent();
            LoadBill();
            LoadGrid(_lstBill);
            //LoadCmbStaff();
        }
        public void LoadBill()
        {
            _lstBill.Clear();
            foreach (var x in _billsv.GetHoadons(null))
            {
                HoadonViewModel tmp = new HoadonViewModel()
                {
                    Id = x.Id,
                    Ngaytao = x.Ngaytao,
                    Ghichu = x.Ghichu,
                    Trangthai = x.Trangthai,
                    TongTienCuaHoaDon = _billsv.TongTienHoaDon(x.Id),
                    Idnhanvien = x.Idnhanvien,
                    Idkhachhang = x.Idkhachhang,
                    Idkhuyenmai = x.Idkhuyenmai
                };
                _lstBill.Add(tmp);
            }
        }
        //public void LoadCmbStaff()
        //{
        //    foreach (var s in _staffsv.GetAll())
        //    {
        //        cmb_FilterbyStaff.Items.Add(s.Ten);

        //    }
        //    //cmb_Sale.SelectedIndex = 0;
        //    cmb_FilterbyStaff.DropDownStyle = ComboBoxStyle.DropDownList;
        //}

        public void LoadGrid(List<HoadonViewModel> lst)
        {
            int stt = 1;
            dtg_Bill.DataSource = null;
            dtg_Bill.Rows.Clear();
            dtg_Bill.ColumnCount = 9;
            dtg_Bill.Columns[0].Name = "STT";
            dtg_Bill.Columns[1].Name = "ID";
            dtg_Bill.Columns[1].Visible = false;
            dtg_Bill.Columns[2].Name = "Ngày tạo";
            dtg_Bill.Columns[3].Name = "Ghi chú";
            dtg_Bill.Columns[4].Name = "Trạng thái";
            dtg_Bill.Columns[5].Name = "Tổng tiền của hóa đơn";
            dtg_Bill.Columns[6].Name = "Nhân viên bán hàng";
            dtg_Bill.Columns[7].Name = "Khách hàng";
            dtg_Bill.Columns[8].Name = "Khuyến mãi đã dùng";


            dtg_Bill.AllowUserToAddRows = false;
            foreach (var x in lst)
            {
                if (string.IsNullOrEmpty(x.Ghichu))
                {
                    x.Ghichu = "Không có ghi chú";
                }
                if (x.Idkhuyenmai == null)
                {
                    dtg_Bill.Rows.Add(stt++, x.Id, x.Ngaytao, x.Ghichu, x.Trangthai, x.TongTienCuaHoaDon, _Staffsv.GetNameStaffById(x.Idnhanvien), _Customersv.GetTenBYId(x.Idkhachhang), "Không dùng khuyến mãi");
                }
                else
                    dtg_Bill.Rows.Add(stt++, x.Id, x.Ngaytao, x.Ghichu, x.Trangthai, x.TongTienCuaHoaDon, _Staffsv.GetNameStaffById(x.Idnhanvien), _Customersv.GetTenBYId(x.Idkhachhang), _saleSV.GetTenById(ProductValidate.convertGUID(x.Idkhuyenmai)));
            }
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            var start = dtpk_start.Value;
            var end = dtpk_end.Value;
            var lstFilter = _lstBill.Where(c => c.Ngaytao >= start && c.Ngaytao <= end).ToList();
            LoadGrid(lstFilter);

        }

        private void dtpk_FilterByTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
