using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    internal interface IPictureRP
    {
        public bool Add(Anh Anh);
        public bool Update(Anh Anh);
        public bool Delete(Anh Anh);

    }
}
