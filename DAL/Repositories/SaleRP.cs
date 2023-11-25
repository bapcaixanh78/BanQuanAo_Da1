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
    public class SaleRP : ISaleRP
    {
        private ShopDbcontext _dbcontext;
        public SaleRP()
        {

            _dbcontext = new ShopDbcontext();
        }

        public bool Add(Khuyenmai KM)
        {
            throw new NotImplementedException();
        }

        public List<Khuyenmai> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Khuyenmai KM)
        {
            throw new NotImplementedException();
        }
    }
}
