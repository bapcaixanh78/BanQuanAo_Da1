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
    public class SaleSV : ISaleSV
    {
        private SaleRP saleRP;
        public SaleSV()
        {
            saleRP = new SaleRP();
        }

        public string Add(Khuyenmai KM)
        {
            if(saleRP.Add(KM))
            {
                return "Sale added successfully";
            }
            else
            {
                return "Failed to add Sale";
            }
        }

        public string Delete(Guid id)
        {
            var khuyenmai = saleRP.GetAll().FirstOrDefault(x=> x.Id == id);
            if(saleRP.Delete(khuyenmai))
            {
                return "Sale deleted successfully";
            }
            else
            {
                return "Failed to delete Sale";
            }
        }

        public int GetDiscountByName(string name)
        {
            return GetKM().FirstOrDefault(c=>c.Tenmakhuyenmai == name).Giamgia;
        }

        public List<Khuyenmai> GetKhuyenMaiByName(string name)
        {
            return saleRP.GetKhuyemaiByName(name);
        }

        public List<Khuyenmai> GetKM()
        {
            return saleRP.GetAll();
        }

        public string Update(Guid id, Khuyenmai KM)
        {
            var khuyenmai = saleRP.GetAll().FirstOrDefault(x => x.Id == id);
            khuyenmai.Tenmakhuyenmai = KM.Tenmakhuyenmai;
            khuyenmai.Thoigianbatdau = KM.Thoigianbatdau;
            khuyenmai.Thoigianketthuc = KM.Thoigianketthuc;
            khuyenmai.Giamgia = KM.Giamgia;
            khuyenmai.Mota = KM.Mota;
            if (saleRP.Update(khuyenmai))
            {
                return "Update Successfully";
            }
            else
            {
                return "Update failed";
            }
        }
    }
}
