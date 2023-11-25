using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    internal interface ISaleRP
    {
        public bool Add(Khuyenmai KM);
        public bool Update(Khuyenmai KM);
        public List<Khuyenmai> GetAll();
    }
}
