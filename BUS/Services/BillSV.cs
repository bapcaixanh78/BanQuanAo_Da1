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

        public string AddBill(Hoadon hoadon)
        {
            if (billRP.Add(hoadon) == true)
            {
                return "You have added successfully";
            }
            else
            {
                return "You have failed to add";
            }
        }

        public List<Hoadon> GetHoadons(string search)
        {
            return billRP.GetAll();
        }

    }
}
