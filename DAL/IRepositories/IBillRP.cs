using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    internal interface IBillRP
    {
        public bool Add(Hoadon HD);
        public List<Hoadon> GetAll();

    }
}
