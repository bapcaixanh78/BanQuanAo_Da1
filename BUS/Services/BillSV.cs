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
    public class BillSV : IBillSV
    {
        private BillRP billRP;
        public BillSV()
        {
            billRP = new BillRP();
        }
        public List<Hoadon> GetHoadons(string search)
        {
            throw new NotImplementedException();
        }
    }
}
