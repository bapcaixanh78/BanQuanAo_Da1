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
    public class DetailPRoductsSV : IDetailProductsSV
    {
        private DetailProductsRP detailProductsRP;
        public DetailPRoductsSV()
        {
            detailProductsRP = new DetailProductsRP();
        }
        public string Add(Chitietsanpham CTSP)
        {
            throw new NotImplementedException();
        }

        public string Delete(Chitietsanpham CTSP)
        {
            throw new NotImplementedException();
        }

        public List<Chitietsanpham> GetAll()
        {
            throw new NotImplementedException();
        }

        public string Update(Chitietsanpham CTSP)
        {
            throw new NotImplementedException();
        }
    }
}
