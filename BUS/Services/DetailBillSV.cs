using BUS.IServices;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class DetailBillSV : IDetailBillSV
    {
        private DetailBillRP detailBillRP;
        public DetailBillSV()
        {
            detailBillRP = new DetailBillRP();
        }
    }
}
