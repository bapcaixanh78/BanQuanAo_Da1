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
    public class BillRP : IBillRP
    {
        private ShopDbcontext _dbcontext;
        public BillRP()
        {
            _dbcontext = new ShopDbcontext();
        }
        public bool Add(Hoadon HD)
        {
            throw new NotImplementedException();
        }

        public List<Hoadon> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
