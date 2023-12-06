using DAL.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IDetailProductsSV
    {
        public string Add(Chitietsanpham CTSP);
        public string Update(Chitietsanpham CTSP);
        public string Delete(Chitietsanpham CTSP);
        public List<Chitietsanpham> GetAll(string search);
        public List<Chitietsanpham> GetAll1(string search);
        public List<Chitietsanpham> GetAllSanphamConHang();
        public Image GetImageByPath(Guid ID);
        public string GetPathImgByIdImg(Guid ID);
        public Guid convertGUID(Guid? guid);
    }
}
