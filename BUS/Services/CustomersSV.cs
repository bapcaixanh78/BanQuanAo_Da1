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
    public class CustomersSV : ICustomersSV
    {
        private CustomersRP customersRP;
        public CustomersSV()
        {
            customersRP = new CustomersRP();
        }

        public string Add(Khachhang kh)
        {
            if (customersRP.Add(kh) == true)
            {
                return "You have added successfully";
            }
            else
            {
                return "You have failed to add";
            }
        }

        public bool ChecktrungSDTKH(string KH)
        {
            var check = GetAll().FirstOrDefault(c=>c.Sdt.Trim() == KH.Trim());
            if (check == null)
            {

                return true;//add kh moi
            }
            else return false; // khong add
        }

        public string Delete(Khachhang kh)
        {
            throw new NotImplementedException();
        }

        public List<Khachhang> GetAll()
        {
            return customersRP.GetKH();
        }

        public Guid GetIDBYSDT(string SDT)
        {
            var tmp = GetAll().FirstOrDefault(c=>c.Sdt.Trim().Equals(SDT.Trim()));
            return tmp.Id;
        }

        public List<Khachhang> GetKH(string search)
        {
            return customersRP.GetKHbyName(search);
        }

        public string GetTenBYId(Guid id)
        {
            return GetAll().FirstOrDefault(c => c.Id == id).Ten;
        }

        public string GetTenBySDt(string SDt)
        {
            List<string> Lstsdt = GetAll().Select(c=>c.Sdt).ToList();
            bool check = Lstsdt.Contains(SDt);
            if(check)
            {
                return GetAll().FirstOrDefault(c => c.Sdt == SDt).Ten;
            }
            else
            {
                return "";
            }
        }

        public string Update(Khachhang kh)
        {
            throw new NotImplementedException();
        }
    }
}
