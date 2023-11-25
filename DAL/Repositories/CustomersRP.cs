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
    public class CustomersRP : ICustomersRP
    {
        private ShopDbcontext _dbcontext;
        public CustomersRP()
        {
            _dbcontext = new ShopDbcontext();
        }
        public bool Add(Khachhang KH)
        {
            throw new NotImplementedException();
        }

        public List<Khachhang> GetKH()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Khachhang KH)
        {
            throw new NotImplementedException();
        }

        public bool Update(Khachhang KH)
        {
            throw new NotImplementedException();
        }
    }
}
