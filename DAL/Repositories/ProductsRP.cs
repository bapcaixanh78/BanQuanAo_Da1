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
            _dbcontext.Add(SP);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(Sanpham SP)
        {
            _dbcontext.Remove(SP);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<Sanpham> GetAll()
        {
            return _dbcontext.Sanphams.ToList();
        }

        public bool Update(Sanpham SP)
        {
            _dbcontext.Update(SP);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
