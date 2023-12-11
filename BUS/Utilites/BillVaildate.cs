using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Utilites
{
    public class BillVaildate
    { 
        private static Hoadonchitiet Hoadonchitiet = new Hoadonchitiet();

        public BillVaildate()
        {
            Hoadonchitiet = new Hoadonchitiet();
        }
        public static bool Checkifstartdatelaterenddate(DateTime startdate, DateTime enddate)
        {

            if (startdate.Date > enddate.Date)
            {
                return true;
            }
            return false;
        }
    }
}
