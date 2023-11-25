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
    public class StaffRP : IStaffRP
    {
        private ShopDbcontext _dbcontext;
        public StaffRP()
        {
            _dbcontext = new ShopDbcontext();
        }
        public bool Add(Nhanvien NV)
        {
            throw new NotImplementedException();
        }

        public List<Nhanvien> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Lock(Nhanvien NV)
        {
            throw new NotImplementedException();
        }

        public bool Update(Nhanvien NV)
        {
            throw new NotImplementedException();
        }
    }
}
