using DAL.IRepositories;
using DAL.Model;
using DAL.Mydbcontext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ProductsRP : IProductsRP
    {
        private ShopDbcontext _dbcontext;
        public ProductsRP()
        {
            _dbcontext = new ShopDbcontext();
        }
        public bool Add(Sanpham SP)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Sanpham SP)
        {
            throw new NotImplementedException();
        }

        public List<Sanpham> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Sanpham SP)
        {
            throw new NotImplementedException();
        }
    }
}
