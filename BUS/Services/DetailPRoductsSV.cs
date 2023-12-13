using BUS.IServices;
using DAL.Model;
using DAL.Repositories;
using System.Data;
using System.Drawing;
namespace BUS.Services
{
    public class DetailPRoductsSV : IDetailProductsSV
    {
        private DetailProductsRP detailProductsRP;
        private ProductsRP productsRP;
        private PictureRP pictureRP;
        public DetailPRoductsSV()
        {
            detailProductsRP = new DetailProductsRP();
            productsRP = new ProductsRP();
            pictureRP = new PictureRP();
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


            if (detailProductsRP.Delete(clone) == true)
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
            clone.Iddanhmuc = CTSP.Iddanhmuc;
            clone.Mota = CTSP.Mota;
            clone.IdAnh = CTSP.IdAnh;
            if (detailProductsRP.Update(clone))
            {
                return "You have updated successfully";
            }
            else
            {
                return "You have failed to update";
            }
        }

        public Image GetImageByPath(Guid ID)
        {
            try
            {
                Image image = null;
                Chitietsanpham timSanPham = detailProductsRP.GetAll().FirstOrDefault(c => c.Id == ID);
                if (timSanPham != null)
                {
                    string imagePath = GetPathImgByIdImg(convertGUID(timSanPham.IdAnh));
                    if (!File.Exists($@"{imagePath}"))
                    {
                        image = null;
                    }
                    else
                    {
                        image = Image.FromFile($@"{imagePath}");
                    }
                }
                return image;
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public string GetPathImgByIdImg(Guid ID)
        {
            var tmp = pictureRP.GetAll().FirstOrDefault(c => c.Idanh == ID).Path;
            if (tmp != null)
            {
                return tmp;
            }
            return "Not found image!";

        }

        public Guid convertGUID(Guid? guid)
        {
            return guid ?? Guid.Empty;
        }


        public string GetTenSP(Guid idchitiet)
        {
            var ctsp = detailProductsRP.GetAll().FirstOrDefault(c => c.Id == idchitiet);
            var sp = productsRP.GetAll().FirstOrDefault(c => c.Id == ctsp.Idsanpham);
            return sp.Ten;
        }

        public List<Chitietsanpham> GetLstSpConHang()
        {
            return GetAll1(null).Where(c => c.Soluongton > 0).ToList();
        }
        public List<Chitietsanpham> GetLstSpHetHang()
        {
            return GetAll1(null).Where(c => c.Soluongton ==0).ToList();
        }

        public Chitietsanpham GetSP(Guid id)
        {
            return detailProductsRP.GetAll().Where(x=> x.Id == id).FirstOrDefault();
        }
    }
}

