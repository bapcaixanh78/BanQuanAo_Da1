using BUS.IServices;
using DAL.IRepositories;
using DAL.Model;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BUS.Services
{
    public class SizeSv : ISizeSV
    {
        private SizeRP sizeRP;

        public SizeSv()
        {
            sizeRP = new SizeRP();
        }

        public Guid convertGUID(Guid? guid)
        {
            
                return guid ?? Guid.Empty;
            
        }

        public Guid FindIDbyName(string name)
        {
            return sizeRP.GetKichthuocs().FirstOrDefault(c => c.Size == name).Id;
        }

        public string FindNamebyID(Guid id)
        {
            return sizeRP.GetKichthuocs().FirstOrDefault(c => c.Id == id).Size;
        }

        public List<Kichthuoc> GetKichthuocs()
        {
            return sizeRP.GetKichthuocs();
        }
    }
}
