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
    public class DetailBillRP : IDetailBillRP
    {
        private ShopDbcontext _dbcontext;
        public DetailBillRP()
        {
            
            _dbcontext = new ShopDbcontext();
        }
        public bool Add(Hoadonchitiet HDCT)
        {
            _dbcontext.Add(HDCT);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(Hoadonchitiet HDCT)
        {
            _dbcontext.Remove(HDCT);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<Hoadonchitiet> GetAll()
        {
            return _dbcontext.Hoadonchitiets.ToList();
        }

        public bool Update(Hoadonchitiet HDCT)
        {
            _dbcontext.Update(HDCT);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
