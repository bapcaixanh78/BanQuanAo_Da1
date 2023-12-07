using BUS.IServices;
using DAL.Model;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class DetailBillSV : IDetailBillSV
    {
        private DetailBillRP detailBillRP;
        public BillRP _billsv;
        public DetailBillSV()
        {

            detailBillRP = new DetailBillRP();
            _billsv = new BillRP();
        }

        public string AddDetailBill(Hoadonchitiet hdct)
        {
            if (detailBillRP.Add(hdct) == true)
            {
                return "You have added successfully";
            }
            else
            {
                return "You have failed to add";
            }
        }

        public decimal DoanhThuMangVe(Guid idnv)
        {
            //lấy ra tất cả id hóa đơn của 1 thằng nhân viên bán được
            var lstbill = _billsv.GetAll().Where(c => c.Idnhanvien == idnv).Select(c => c.Id).ToList();
            decimal tongtien = 0;
            foreach (var bill in lstbill)
            {
                tongtien += GetAllHoaDonChiTiet().FirstOrDefault(c => c.Idhoadon == bill).Giaban;
            }
            return tongtien;
        }

        public List<Hoadonchitiet> GetAllHoaDonChiTiet()
        {
            return detailBillRP.GetAll();
        }
    }
}
