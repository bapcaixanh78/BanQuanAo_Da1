using BUS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Utilites
{
    public class SaleValidate
    {
        private static SaleSV SaleSV = new SaleSV();

        public SaleValidate()
        {
            SaleSV = new SaleSV();
        }
        public static bool CheckIfSaleNameExist(string name)
        {
            if (SaleSV.GetKM().Find(x => x.Tenmakhuyenmai == name) != null)
            {
                return true;
            }
            return false;
        }

        public static bool CheckIfSaleNameExistUpdate(string originalName, string updateName)
        {
            var khuyenmais = SaleSV.GetKM();
            if (originalName == updateName)
            {
                return false;
            }
            if (SaleSV.GetKM().Find(x => x.Tenmakhuyenmai == updateName) != null)
            {
                return true;
            }
            return false;
        }
        public static bool Checkifstartdatelaterenddate(DateTime startdate, DateTime enddate)
        {
            
            if(startdate.Date > enddate.Date) 
            {
                return true;
            }
            return false;
        }
        public static bool Checkifstartdate(DateTime startdate)
        {
            var noww = DateTime.Now.DayOfYear;
            var start = startdate.DayOfYear;
           
            if(noww - start > 0 && DateTime.Now.Year - startdate.Year >=0)
            {
                return false;
            }
            else { return true; }
        }
        public static bool CheckifstartdateUpdate(DateTime newdate, DateTime olddate)
        {
            if (olddate <= newdate)
            {
                return false;
            }
            return true;
        }

        public static bool CheckEnddatetoolong(DateTime enddate, DateTime startdate)
        {
            if(enddate.Year - startdate.Year <= 1)
            {
                return true;
            }
            return false;
        }

    }
}
