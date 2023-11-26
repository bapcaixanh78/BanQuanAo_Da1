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
        public string Add(Chitietsanpham CTSP,Sanpham SP);
        public string Update(Chitietsanpham CTSP, Sanpham SP);
        public string Delete(Chitietsanpham CTSP, Sanpham SP);
        public List<Chitietsanpham> GetAll(string search);
    }
}
