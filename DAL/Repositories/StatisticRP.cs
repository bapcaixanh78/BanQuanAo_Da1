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
    public class StatisticRP : IStatisticRP
    {
        private ShopDbcontext _dbcontext;
        public StatisticRP()
        {
            _dbcontext = new ShopDbcontext();
        }
        public List<Hoadonchitiet> All()
        {
            throw new NotImplementedException();
        }
    }
}
