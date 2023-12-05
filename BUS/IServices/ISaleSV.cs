using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface ISaleSV
    {
        public string Update(Guid id, Khuyenmai KM);
        public string Add(Khuyenmai KM);
        public string Delete(Guid id);
        public List<Khuyenmai> GetKhuyenMaiByName(string name);
        public int GetDiscountByName(string name);

        public List<Khuyenmai> GetKM();
        public Guid GetidKhuyenMaiByName(string name);
    }
}
