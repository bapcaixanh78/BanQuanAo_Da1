using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    internal interface IProductsSV
    {
        public string Add(Sanpham SP);
        public string Update(Sanpham SP);
        public string Delete(Sanpham SP);
        public List<Sanpham> GetSP(string search);
    }
}
