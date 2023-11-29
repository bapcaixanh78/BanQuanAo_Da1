using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IPictureSV
    {
        public string AddImg(Anh img);
        public string DeleteImg(Guid id);
        public string UpdateImg(Anh anh);
        public Guid FindIdByPath(string path);
        public List<Anh> Getall();
        public List<string> GetLstPath();
    }
}
