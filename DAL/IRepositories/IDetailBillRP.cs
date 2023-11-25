using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    internal interface IDetailBillRP
    {
        public bool Add(Hoadonchitiet HDCT);
        public bool Update(Hoadonchitiet HDCT);
        public bool Delete(Hoadonchitiet HDCT);
        public List<Hoadonchitiet> GetAll();
    }
}
