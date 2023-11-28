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
        public string Delete(Khachhang kh)
        {
            throw new NotImplementedException();
        }

        public List<Khachhang> GetAll()
        {
            return customersRP.GetKH();
        }

        public List<Khachhang> GetKH(string search)
        {
            return customersRP.GetKHbyName(search);
        }
        

        public string Update(Khachhang kh)
        {
            throw new NotImplementedException();
        }
    }
}
