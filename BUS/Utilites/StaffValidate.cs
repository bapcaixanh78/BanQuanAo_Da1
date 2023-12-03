using BUS.Services;
using DAL.Model;
using System.Text.RegularExpressions;

namespace BUS.Utilites
{
    public class StaffValidate
    {
        private static StaffSV staffSV = new StaffSV();

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

        public static bool CheckIfContainSymbol(string input)
        {
            // Regular expression pattern to match symbols
            string pattern = @"[!@#$%^&*()\-_=+[\]{}|;:'\"",.<>/?]";

            // Check if input contains symbols
            return Regex.IsMatch(input, pattern);
        }

        public static bool CheckIfContainNumber(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckIfAccountListIsEmpty()
        {
            List<Nhanvien> nhanviens = staffSV.GetAll();
            if (nhanviens == null)
            {
                return true;
            }
            return false;
        }

        public static bool CheckIfStaffAccountNameExist(string name)
        {
            if (staffSV.GetAll().Find(x => x.Taikhoan == name) != null)
            {
                return true;
            }
            return false;
        }

        public static bool CheckIfStaffAccountNameExistUpdate(string originalName, string updateName)
        {
            var nhanviens = staffSV.GetAll();
            if (originalName == updateName)
            {
                return false;
            }
            if (staffSV.GetAll().Find(x => x.Ten == updateName) != null)
            {
                return true;
            }
            return false;
        }

        public static bool CheckEmail(string email)
        {
            string emailRegex = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";
            return Regex.IsMatch(email, emailRegex);
        }
    }
}