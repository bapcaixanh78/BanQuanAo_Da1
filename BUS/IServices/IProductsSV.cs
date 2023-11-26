using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IProductsSV
    {
        public string Add(Sanpham SP);
        public Sanpham Findbyid(Guid id);
        public string Update(Sanpham SP);
        public string Delete(Sanpham SP);
        public List<Sanpham> GetSP(string search);
    }
}
