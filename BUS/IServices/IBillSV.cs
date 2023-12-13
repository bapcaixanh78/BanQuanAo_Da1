using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IBillSV
    {
        public string AddBill(Hoadon hoadon);
        public string UpdateBill(Hoadon hoadon);
        public List<Hoadon> GetHoadons(string search);
        public decimal TongTienHoaDon(Guid Idhd, Guid idKM);
        public int GetCountBillInaStaff(Guid idnv);
        public List<Hoadon> Getlistofunpaidinvoices();
    }
}
