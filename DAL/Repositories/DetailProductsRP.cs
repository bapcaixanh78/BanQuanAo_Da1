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
    public class DetailProductsRP : IDetailProductsRP
    {
        private ShopDbcontext _shopDbcontext;
        public DetailProductsRP()
        {
            _shopDbcontext = new ShopDbcontext();
        }
        public bool Add(Chitietsanpham CTSP)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Chitietsanpham CTSP)
        {
            throw new NotImplementedException();
        }

        public List<Chitietsanpham> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Chitietsanpham CTSP)
        {
            throw new NotImplementedException();
        }
    }
}
