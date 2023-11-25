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
    public class ProductsSV : IProductsSV
    {
        private ProductsRP productsRP;
        public ProductsSV()
        {
            productsRP = new ProductsRP();
        }
        public string Add(Sanpham SP)
        {
            throw new NotImplementedException();
        }

        public string Delete(Sanpham SP)
        {
            throw new NotImplementedException();
        }

        public List<Sanpham> GetSP(string search)
        {
            throw new NotImplementedException();
        }

        public string Update(Sanpham SP)
        {
            throw new NotImplementedException();
        }
    }
}
