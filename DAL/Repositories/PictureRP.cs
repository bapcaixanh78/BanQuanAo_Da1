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
    public class PictureRP : IPictureRP
    {
        private ShopDbcontext _dbcontext;
        public PictureRP()
        {
            _dbcontext = new ShopDbcontext();
        }
        public bool Add(Anh Anh)
        {
            _dbcontext.Add(Anh);
            _dbcontext.SaveChanges();
            return true;
        }

        public bool Delete(Anh Anh)
        {
            _dbcontext.Remove(Anh);
            _dbcontext.SaveChanges();
            return true;
        }

        public List<Anh> GetAll()
        {
            return _dbcontext.Anhs.ToList();
        }

        public bool Update(Anh Anh)
        {
            _dbcontext.Update(Anh);
            _dbcontext.SaveChanges();
            return true;
        }
    }
}
