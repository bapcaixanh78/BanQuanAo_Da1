using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    internal interface ICustomersRP
    {
        public bool Add(Khachhang KH);
        public bool Remove(Khachhang KH);
        public bool Update(Khachhang KH);
        public List<Khachhang> GetKH();

        public List<Khachhang> GetKHbyName(string name);

        
    }
}
