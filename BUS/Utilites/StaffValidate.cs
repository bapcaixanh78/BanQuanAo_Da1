using BUS.Services;
using DAL.Model;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Utilites
{
    public class StaffValidate
    {
        static StaffSV staffSV = new StaffSV();

        public StaffValidate()
        {
            staffSV = new StaffSV();
        }

        public static bool CheckEmptyString(string input)
        {
            if (input.Trim().Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool CheckIfAccountListIsEmpty()
        {
           List<Nhanvien> nhanviens = staffSV.GetAll();
            if(nhanviens == null)
            {
                return true;
            }return false;
        }

        public static bool CheckIfStaffAccountNameExist(string name)
        {
            if (staffSV.GetAll().Find(x => x.Taikhoan == name) != null)
            {
                return true;
            }
            return false;
        }
    }
}
