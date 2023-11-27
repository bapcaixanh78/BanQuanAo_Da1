using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface ISizeSV
    {
        public List<Kichthuoc> GetKichthuocs();

        public Guid FindIDbyName(string name);
        public Guid convertGUID(Guid? guid);
        public string FindNamebyID(Guid id);
    }
}
