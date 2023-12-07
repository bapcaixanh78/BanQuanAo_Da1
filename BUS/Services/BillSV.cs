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
        public BillSV()
        {
            detailbill = new DetailBillSV();
            billRP = new BillRP();
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

        public decimal TongTienHoaDon(Guid Id)
        {
            decimal tongtienhoadon = 0;
            //lấy 1 list giá từng hóa đơn chi tiết trong 1 hóa đơn
            var lsttongtiencua1hdct = detailbill.GetAllHoaDonChiTiet().Where(h => h.Idhoadon == Id).Select(c=>c.Giaban);//Giá này là giá tổng sản phẩm mua trong từng hóa đơn chi tiết (Số lượng * giá 1 sản phẩm)
            foreach(var x in lsttongtiencua1hdct)
            {
                tongtienhoadon += x;
            }return tongtienhoadon;
        }

        public int GetCountBillInaStaff(Guid idnv)
        {
            var lst = GetHoadons(null).Where(c=>c.Idnhanvien == idnv).ToList().Count;
            return lst;
        }
    }
}
