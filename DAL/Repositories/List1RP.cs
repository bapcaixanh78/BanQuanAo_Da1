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
    public class List1RP : IListRP1
    {
        private ShopDbcontext _dbcontext;
        public List1RP()
        {
            _dbcontext = new ShopDbcontext();
        }

        public List<Danhmuc> GetDanhmucs()
        {
            return _dbcontext.Danhmucs.ToList();
        }
    }
}

