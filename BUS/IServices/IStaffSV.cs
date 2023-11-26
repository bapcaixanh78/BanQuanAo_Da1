using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IStaffSV
    {
        public string Add(Nhanvien NV);
        public string Update(Nhanvien NV);
        public string Lock(Nhanvien NV);

        public List<Nhanvien> GetNV(string search);
    }
}
