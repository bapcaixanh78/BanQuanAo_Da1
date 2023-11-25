using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    internal interface IDetailProductsRP
    {
        public bool Add(Chitietsanpham CTSP);
        public bool Update(Chitietsanpham CTSP);
        public bool Delete(Chitietsanpham CTSP);
        public List<Chitietsanpham> GetAll();

    }
}
