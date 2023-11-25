using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BUS.IServices
{
    internal interface ICustomersSV
    {
        public string Update(Khachhang kh);
        public string Delete(Khachhang kh);
        public List<Khachhang> GetKH(string search);
    }
}
