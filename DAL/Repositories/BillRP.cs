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
            _dbcontext.Add(HD);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<Hoadon> GetAll()
        {
            return _dbcontext.Hoadons.ToList();
        }

        public bool Update(Hoadon HD)
        {
            _dbcontext.Update(HD);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
