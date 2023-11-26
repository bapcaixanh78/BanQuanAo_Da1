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
        private ProductsRP productsRP;
        public DetailPRoductsSV()
        {
            detailProductsRP = new DetailProductsRP();
            productsRP = new ProductsRP();
        }
        public string Add(Chitietsanpham CTSP,Sanpham SP)
        {
            if (detailProductsRP.Add(CTSP) == true && productsRP.Add(SP)) 
            {
                return "You have added successfully";
            }
            else
            {
                return "You have failed to add";
            }
        }

        

        public string Delete(Chitietsanpham CTSP, Sanpham SP)
        {
            var clone = detailProductsRP.GetAll().FirstOrDefault(x => x.Id == CTSP.Id);
            var clone1 = productsRP.GetAll().FirstOrDefault(y => y.Id == SP.Id);

            if (detailProductsRP.Delete(clone) == true && productsRP.Delete(clone1) == true)
            {
                return "You have removed successfully";
            }
            else
            {
                return "You have failed to remove";
            }
        }

        

        public List<Chitietsanpham> GetAll(string search)
        {
            if (search == null) // ko search
            {
                return detailProductsRP.GetAll();
            }
            else
            {
                return detailProductsRP.GetAll().Where(x => x.Sanpham.Ten.ToLower().Trim().Contains(search)).ToList();
            }
        }

       

        public string Update(Chitietsanpham CTSP, Sanpham SP)
        {
            var clone = detailProductsRP.GetAll().FirstOrDefault(x => x.Id == CTSP.Id);
            var clone1 = productsRP.GetAll().FirstOrDefault(z => z.Id == SP.Id);
            clone1.Ten = SP.Ten;
            clone.Gianhap = CTSP.Gianhap;
            clone.Giaban = CTSP.Giaban;
            clone.Soluongton = CTSP.Soluongton;
            clone.Mauao = CTSP.Mauao;
            clone.Kichthuoc = CTSP.Kichthuoc;
            clone.Chatlieu = CTSP.Chatlieu;
            clone.Mota=CTSP.Mota;
            if (detailProductsRP.Update(clone) == true&& productsRP.Update(clone1))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

        
        }
    }

