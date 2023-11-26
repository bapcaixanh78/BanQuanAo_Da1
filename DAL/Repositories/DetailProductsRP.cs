using DAL.IRepositories;
using DAL.Model;
using DAL.Mydbcontext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class DetailProductsRP : IDetailProductsRP
    {
        private ShopDbcontext _shopDbcontext;
        public DetailProductsRP()
        {
            _shopDbcontext = new ShopDbcontext();
        }
        public bool Add(Chitietsanpham CTSP)
        {
            _shopDbcontext.Add(CTSP);
            _shopDbcontext.SaveChanges();
            return true;
        }

        public bool Delete(Chitietsanpham CTSP)
        {
            _shopDbcontext.Remove(CTSP);
            _shopDbcontext.SaveChanges();
            return true;
        }

        public List<Chitietsanpham> GetAll()
        {
            return _shopDbcontext.Chitietsanphams.ToList();
        }

        public bool Update(Guid id, Chitietsanpham CTSP)
        {
            _shopDbcontext.Update(CTSP);
            _shopDbcontext.SaveChanges();
            return true;
        }

        public bool Update(Chitietsanpham clone)
        {
            throw new NotImplementedException();
        }
    }
}
