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
            _dbcontext.Add(NV);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<Nhanvien> GetAll()
        {
            return _dbcontext.Nhanvien.ToList();
        }

        public List<Nhanvien> GetStaffByName(string name)
        {
            var nameNV= _dbcontext.Nhanvien.Where(x => x.Ten.Contains(name)).ToList();
            return nameNV;
        }

        public bool Update(Nhanvien NV)
        {
            _dbcontext.Update(NV);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
