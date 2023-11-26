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
    public class SizeSv : ISizeSV
    {
        private SizeRP sizeRP;

        public SizeSv()
        {
            sizeRP = new SizeRP();
        }
        public List<Kichthuoc> GetKichthuocs()
        {
            return sizeRP.GetKichthuocs();
        }
    }
}
