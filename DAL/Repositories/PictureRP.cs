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
            throw new NotImplementedException();
        }

        public bool Delete(Anh Anh)
        {
            throw new NotImplementedException();
        }

        public bool Update(Anh Anh)
        {
            throw new NotImplementedException();
        }
    }
}
