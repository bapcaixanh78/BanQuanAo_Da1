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
    public class MaterialRP : IMaterialRP
    {
        private ShopDbcontext _dbcontext;
        public MaterialRP()
        {

            _dbcontext = new ShopDbcontext();
        }
        public List<Chatlieu> GetChatlieus()
        {
            return _dbcontext.Chatlieus.ToList();
        }
    }
}
