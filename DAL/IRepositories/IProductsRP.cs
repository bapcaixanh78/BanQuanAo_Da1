using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    internal interface IProductsRP
    {
        public bool Add(Sanpham SP);
        public bool Update(Sanpham SP);
        public bool Delete(Sanpham SP);
        public List<Sanpham> GetAll();
    }
}
