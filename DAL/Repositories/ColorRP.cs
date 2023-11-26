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
    public class ColorRP : IColorRP
    {
        private ShopDbcontext _dbcontext;
        public ColorRP()
        {
            _dbcontext = new ShopDbcontext();
        }
        public List<Mauao> GetMauaos()
        {
            return _dbcontext.Mauaos.ToList();
        }
    }
}
