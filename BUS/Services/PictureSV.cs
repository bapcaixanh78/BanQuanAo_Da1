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
    public class PictureSV : IPictureSV
    {
        public PictureRP PictureRP { get; set; }

        public PictureSV()
        {
            PictureRP = new PictureRP();
        }

        public string AddImg(Anh img)
        {
            if (PictureRP.Add(img) == true)
            {
                return "You have added successfully";
            }
            else
            {
                return "You have failed to add";
            }
        }

        public string DeleteImg(Guid id)
        {
            var clone = PictureRP.GetAll().FirstOrDefault(x => x.Idanh == id);


            if (PictureRP.Delete(clone) == true)
            {
                return "You have removed successfully";
            }
            else
            {
                return "You have failed to remove";
            }
        }



        public string UpdateImg(Anh anh)
        {
            var clone = PictureRP.GetAll().FirstOrDefault(x => x.Idanh == anh.Idanh);

            clone.Path = anh.Ten;
            if (PictureRP.Update(clone))
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }


        }

        public List<Anh> Getall()
        {
            return PictureRP.GetAll();
        }

        public Guid FindIdByPath(string path)
        {
            return PictureRP.GetAll().FirstOrDefault(c=>c.Path == path).Idanh;
        }

        public List<string> GetLstPath()
        {
            return Getall().Select(c=>c.Path).ToList();
        }
    }
}
