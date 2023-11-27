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
    public class ProductsSV : IProductsSV
    {
        private ProductsRP productsRP;
        public ProductsSV()
        {
            productsRP = new ProductsRP();
        }
        public string Add(Sanpham SP)
        {
            if(productsRP.Add(SP) == true)
            {
                return "You have added successfully";
            }
            else
            {
                return "You have failed to add";
            }
        }

        public string Delete(Sanpham SP)
        {
            var clone = productsRP.GetAll().FirstOrDefault(x => x.Id == SP.Id);


            if (productsRP.Delete(clone) == true)
            {
                return "You have removed successfully";
            }
            else
            {
                return "You have failed to remove";
            }
        }



        public List<Sanpham> GetSP(string search)
        {
            return productsRP.GetAll();
        }

        public string Update(Sanpham SP)
        {
            var clone = productsRP.GetAll().FirstOrDefault(x => x.Id == SP.Id);

            clone.Ten = SP.Ten;
            if (productsRP.Update(clone))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

        public Sanpham Findbyid(Guid id)
        {
            return productsRP.GetAll().FirstOrDefault(c => c.Id == id);
        }

        public Guid FindIDbyName(string name)
        {
            return productsRP.GetAll().FirstOrDefault(c =>c.Ten== name).Id;
        }
    }
}
