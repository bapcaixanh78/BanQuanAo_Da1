﻿using BUS.IServices;
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
        public static List<HoadonViewModel> _lstBillUnpaid = new List<HoadonViewModel>();
        public static List<HoadonViewModel> _lstBillPaid = new List<HoadonViewModel>();
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
            lb_paid.Text = _lstBillPaid.Count.ToString();
            lb_unpaid.Text = _lstBillUnpaid.Count.ToString();
        }
        public void LoadBill()
        {
            _lstBill.Clear();
            _lstBillPaid.Clear();
            _lstBillUnpaid.Clear();
            foreach (var x in _billsv.GetHoadons(null))
            {
                HoadonViewModel tmp = new HoadonViewModel()
                {
                    Id = x.Id,
                    Ngaytao = x.Ngaytao,
                    Ghichu = x.Ghichu,
                    Trangthai = x.Trangthai,
                    TongTienCuaHoaDon = _billsv.TongTienHoaDon(x.Id,ProductValidate.convertGUID(x.Idkhuyenmai)),
                    Idnhanvien = x.Idnhanvien,
                    Idkhachhang = x.Idkhachhang,
                    Idkhuyenmai = x.Idkhuyenmai
                };
                _lstBill.Add(tmp);
                if (x.Trangthai == "Chưa thanh toán")
                {
                    _lstBillUnpaid.Add(tmp);
                }
                else
                {
                    _lstBillPaid.Add(tmp);
                }
            }
        }


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
            dtg_Bill.Columns[4].Name = "Tổng tiền của hóa đơn";
            dtg_Bill.Columns[5].Name = "Nhân viên bán hàng";
            dtg_Bill.Columns[6].Name = "Khách hàng";
            dtg_Bill.Columns[7].Name = "Khuyến mãi đã dùng";
            dtg_Bill.Columns[8].Name = "Trạng thái";


            dtg_Bill.AllowUserToAddRows = false;
            for (int i = 0; i < lst.Count; i++)
            {
                if (string.IsNullOrEmpty(lst[i].Ghichu))
                {
                    lst[i].Ghichu = "Không có ghi chú";
                }
                if (lst[i].Idkhuyenmai == null)
                {
                    dtg_Bill.Rows.Add(stt++, lst[i].Id, lst[i].Ngaytao, lst[i].Ghichu, lst[i].TongTienCuaHoaDon, _Staffsv.GetUserstaffByid(lst[i].Idnhanvien), _Customersv.GetTenBYId(lst[i].Idkhachhang), "Không dùng khuyến mãi", lst[i].Trangthai);
                    if (lst[i].Trangthai == "Chưa thanh toán")
                    {
                        dtg_Bill.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                        dtg_Bill.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else
                    {
                        dtg_Bill.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                        dtg_Bill.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                }

                else
                {
                    dtg_Bill.Rows.Add(stt++, lst[i].Id, lst[i].Ngaytao, lst[i].Ghichu, lst[i].TongTienCuaHoaDon, _Staffsv.GetNameStaffById(lst[i].Idnhanvien), _Customersv.GetTenBYId(lst[i].Idkhachhang), _saleSV.GetTenById(ProductValidate.convertGUID(lst[i].Idkhuyenmai)), lst[i].Trangthai);
                    if (lst[i].Trangthai == "Chưa thanh toán")
                    {
                        dtg_Bill.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                        dtg_Bill.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else
                    {
                        dtg_Bill.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                        dtg_Bill.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                }

            }

        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (BillVaildate.Checkifstartdatelaterenddate(dtpk_start.Value, dtpk_end.Value))
            {
                MessageBox.Show("End date can't be before start date", "Inform");
                return;
            }
            else
            {
                var start = dtpk_start.Value;
                var end = dtpk_end.Value;
                var lstFilter = _lstBill.Where(c => c.Ngaytao >= start && c.Ngaytao <= end).ToList();
                LoadGrid(lstFilter);
            }

        }

        private void dtpk_FilterByTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_chuathanhtoan_Click(object sender, EventArgs e)
        {
            LoadBill();
            LoadGrid(_lstBillUnpaid);
        }

        private void btn_dathanhtoan_Click(object sender, EventArgs e)
        {
            LoadBill();
            LoadGrid(_lstBillPaid);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            LoadBill();
            LoadGrid(_lstBill);
        }
    }
}
