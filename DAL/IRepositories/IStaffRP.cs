using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    internal interface IStaffRP
    {
        public bool Add(Nhanvien NV);
        public bool Update(Nhanvien NV);
        public bool Lock(Nhanvien NV);

        public List<Nhanvien> GetAll();

    }
}
