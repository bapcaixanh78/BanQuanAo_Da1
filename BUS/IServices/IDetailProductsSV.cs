using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    internal interface IDetailProductsSV
    {
        public string Add(Chitietsanpham CTSP);
        public string Update(Chitietsanpham CTSP);
        public string Delete(Chitietsanpham CTSP);
        public List<Chitietsanpham> GetAll();
    }
}
