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
        public string Add(Chitietsanpham CTSP)
        {
            if (detailProductsRP.Add(CTSP) == true) 
            {
                return "You have added successfully";
            }
            else
            {
                return "You have failed to add";
            }
        }

        

        public string Delete(Chitietsanpham CTSP)
        {
            var clone = detailProductsRP.GetAll().FirstOrDefault(x => x.Id == CTSP.Id);
            

            if (detailProductsRP.Delete(clone) == true )
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

        public List<Chitietsanpham> GetAll1(string search)
        {
            //if (search == null)
            //{
            return detailProductsRP.GetAll();
            //}
            //else
            //{
            //    return detailProductsRP.GetAll().Where(x => x.Sanpham.Ten.ToLower().Trim().Contains(search)).ToList();
            //}


        }

        

        public string Update(Chitietsanpham CTSP)
        {
            var clone = detailProductsRP.GetAll().FirstOrDefault(x => x.Id == CTSP.Id);
            
            clone.Gianhap = CTSP.Gianhap;
            clone.Giaban = CTSP.Giaban;
            clone.Soluongton = CTSP.Soluongton;
            clone.Idmauao = CTSP.Idmauao;
            clone.Idkichthuoc = CTSP.Idkichthuoc;
            clone.Idchatlieu = CTSP.Idchatlieu;
            clone.Mota = CTSP.Mota;
            if (detailProductsRP.Update(clone))
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

