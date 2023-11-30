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

        public string Update(Guid id, Nhanvien NVUpdate);

        public string Lock(Guid id);

        public Nhanvien CheckStaffLogin(string username, string password);

        public List<Nhanvien> GetStaffByName(string name);

        public List<Nhanvien> GetAll();
    }
}