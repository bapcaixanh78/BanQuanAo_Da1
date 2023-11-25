using BUS.IServices;
using DAL.Model;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class SaleSV : ISaleSV
    {
        private SaleRP saleRP;
        public SaleSV()
        {
            saleRP = new SaleRP();
        }

        public string Add(Khuyenmai KM)
        {
            throw new NotImplementedException();
        }

        public List<Khuyenmai> GetKM(string search)
        {
            throw new NotImplementedException();
        }

        public string Update(Khuyenmai KM)
        {
            throw new NotImplementedException();
        }
    }
}
