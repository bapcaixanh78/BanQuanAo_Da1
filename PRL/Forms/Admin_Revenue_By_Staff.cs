using BUS.IServices;
using BUS.Services;
using BUS.Utilites;
using PRL.VIewModel;
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
    public partial class Admin_Revenue_By_Staff : Form
    {
        IStaffSV _staffsv;
        IBillSV _billsv;
        IDetailBillSV _detailBillsv;
        public List<Revenue_By_Staff> _lstRevenue;
        public Admin_Revenue_By_Staff()
        {
            _lstRevenue = new List<Revenue_By_Staff>();
            _staffsv = new StaffSV();
            _billsv = new BillSV();
            _detailBillsv = new DetailBillSV();
            InitializeComponent();
            FillList();
            LoadGrid(_lstRevenue);
        }


        public decimal DoanhThuMangVeCua1NhanVien(Guid idnv)
        {
            decimal tongtien = 0;
            var lsttmp = Admin_Bill._lstBill.Where(c=>c.Idnhanvien == idnv).Select(c=>c.TongTienCuaHoaDon).ToList();
            foreach(var x in lsttmp)
            {
                tongtien+= x;
            }return tongtien;
        }
        public void FillList()

        {
            //_lstRevenue.Clear();
            foreach (var nv in _staffsv.GetAll())
            {
                Revenue_By_Staff tmp = new Revenue_By_Staff
                {
                    IdNhanVien = nv.Id,
                    Ten = nv.Ten,
                    Email = nv.Email,
                    Soluonghoadon = _billsv.GetCountBillInaStaff(nv.Id),
                    DoanhThuMangVe = DoanhThuMangVeCua1NhanVien(nv.Id)
                };
                _lstRevenue.Add(tmp);
            }
        }

        public void LoadGrid(List<Revenue_By_Staff> lst)
        {

            int stt = 1;
            dtg_revenuebystaff.Rows.Clear();
            dtg_revenuebystaff.DataSource = null;
            dtg_revenuebystaff.ColumnCount = 6;
            dtg_revenuebystaff.Columns[0].Name = "STT";
            dtg_revenuebystaff.Columns[1].Name = "ID";
            dtg_revenuebystaff.Columns[1].Visible = false;
            dtg_revenuebystaff.Columns[2].Name = "Tên nhân viên";
            dtg_revenuebystaff.Columns[3].Name = "Email";
            dtg_revenuebystaff.Columns[4].Name = "Số lượng hóa đơn";
            dtg_revenuebystaff.Columns[5].Name = "Doanh thu mang về";


            dtg_revenuebystaff.AllowUserToAddRows = false;
            foreach (var x in lst)
            {
                dtg_revenuebystaff.Rows.Add(stt++, x.IdNhanVien, x.Ten, x.Email, x.Soluonghoadon, x.DoanhThuMangVe);
            }
            
        }
    }
}
