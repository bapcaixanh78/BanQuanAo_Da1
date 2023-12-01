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
    public class DetailBillSV : IDetailBillSV
    {
        private DetailBillRP detailBillRP;
        public DetailBillSV()
        {
            detailBillRP = new DetailBillRP();
        }

        public string AddDetailBill(Hoadonchitiet hdct)
        {
            if (detailBillRP.Add(hdct) == true)
            {
                return "You have added successfully";
            }
            else
            {
                return "You have failed to add";
            }
        }

        public List<Hoadonchitiet> GetAllHoaDonChiTiet()
        {
            return detailBillRP.GetAll();
        }
    }
}
