using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IColorSV
    {
        public List<Mauao> GetMauaos();

        public Guid FindIDbyName(string name);

        public string FindNamebyID(Guid id);

        public Guid convertGUID(Guid? guid);
    }
}
