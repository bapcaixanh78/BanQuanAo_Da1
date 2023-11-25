using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    internal interface ISaleSV
    {
        public string Update(Khuyenmai KM);
        public string Add(Khuyenmai KM);

        public List<Khuyenmai> GetKM(string search);
    }
}
