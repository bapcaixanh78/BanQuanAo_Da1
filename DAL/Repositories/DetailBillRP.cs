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
            throw new NotImplementedException();
        }

        public bool Delete(Hoadonchitiet HDCT)
        {
            throw new NotImplementedException();
        }

        public List<Hoadonchitiet> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Hoadonchitiet HDCT)
        {
            throw new NotImplementedException();
        }
    }
}
