using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BUS.IServices
{
    public interface ICustomersSV
    {
        public string Add(Khachhang kh);
        public string Update(Khachhang kh);
        public string Delete(Khachhang kh);
        public List<Khachhang> GetKH(string search);
        public Guid GetIDBYSDT(string SDT);
        public string GetTenBYId(Guid id);
        public string GetTenBySDt(string SDt    );
        public bool ChecktrungSDTKH(string KH);
        public List<Khachhang> GetAll();
    }
}
