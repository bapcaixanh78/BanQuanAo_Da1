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
    public class SizeRP : ISizeRP
    {
        private ShopDbcontext _dbcontext;
        public SizeRP()
        {
            _dbcontext = new ShopDbcontext();
        }
        public List<Kichthuoc> GetKichthuocs()
        {
            return _dbcontext.Kichthuocs.ToList();
        }
    }
}
