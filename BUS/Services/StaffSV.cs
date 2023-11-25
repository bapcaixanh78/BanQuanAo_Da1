using BUS.IServices;
using DAL.Model;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class StaffSV : IStaffSV
    {
        private StaffRP staffRP;
        public StaffSV()
        {
            staffRP = new StaffRP();
        }
        public string Add(Nhanvien NV)
        {
            throw new NotImplementedException();
        }

        public List<Nhanvien> GetNV(string search)
        {
            throw new NotImplementedException();
        }

        public string Lock(Nhanvien NV)
        {
            throw new NotImplementedException();
        }

        public string Update(Nhanvien NV)
        {
            throw new NotImplementedException();
        }
    }
}
