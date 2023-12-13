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
    public class BillSV : IBillSV
    {
        private BillRP billRP;
        public IDetailBillSV detailbill;
        public ISaleSV salesv;
        public BillSV()
        {
            detailbill = new DetailBillSV();
            billRP = new BillRP();
            salesv = new SaleSV();
        }

        public string AddBill(Hoadon hoadon)
        {
            if (billRP.Add(hoadon) == true)
            {
                return "You have added successfully";
            }
            else
            {
                return "You have failed to add";
            }
        }

        public List<Hoadon> GetHoadons(string search)
        {
            return billRP.GetAll();
        }

        public decimal TongTienHoaDon(Guid Idhd, Guid idKM)
        {
            decimal tongtienhoadon = 0;
            //lấy 1 list giá từng hóa đơn chi tiết trong 1 hóa đơn
            var lsttongtiencua1hd = detailbill.GetAllHoaDonChiTiet().Where(h => h.Idhoadon == Idhd).Select(c=>c.Giaban);//Giá này là giá tổng sản phẩm mua trong từng hóa đơn chi tiết (Số lượng * giá 1 sản phẩm)
            foreach(var x in lsttongtiencua1hd)
            {
                tongtienhoadon += x;
            }
            decimal Aftersale = tongtienhoadon - (tongtienhoadon*salesv.GetKM().FirstOrDefault(c => c.Id == idKM).Giamgia/100);
            return Aftersale;
        }

        public int GetCountBillInaStaff(Guid idnv)
        {
            var lst = GetHoadons(null).Where(c=>c.Idnhanvien == idnv).ToList().Count;
            return lst;
        }

        public List<Hoadon> Getlistofunpaidinvoices()
        {
            return GetHoadons(null).Where(c => c.Trangthai == "Chưa thanh toán").ToList();
        }

        public string UpdateBill(Hoadon hoadon)
        {
            var clone = billRP.GetAll().FirstOrDefault(x => x.Id == hoadon.Id);

            clone.Trangthai = hoadon.Trangthai;
            if (billRP.Update(clone))
            {
                return "You have updated successfully";
            }
            else
            {
                return "You have failed to update";
            }
        }
    }
}
