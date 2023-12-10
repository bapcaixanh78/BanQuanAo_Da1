using BUS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BUS.Utilites
{
    public class ProductValidate
    {
        private static ProductsSV productsSV = new ProductsSV();

        public ProductValidate()
        {
            productsSV = new ProductsSV();
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

        public static bool CheckIfContainLetter(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c) && c!='.' && c!=',' && c!='-')
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckIfNegativeValue(string input)
        {
            if(input.StartsWith("-"))
            {
                return false;
            }return true;
        }

        public static bool CheckIfProductNameExist(string name)
        {
            if (productsSV.GetSP(null).Find(x => x.Ten == name) != null)
            {
                return true;
            }
            return false;
        }

        public static bool CheckIfProductNameExistUpdate(string originalName, string updateName)
        {
            var nhanviens = productsSV.GetSP(null);
            if (originalName == updateName)
            {
                return false;
            }
            if (productsSV.GetSP(null).Find(x=>x.Ten == updateName) != null)
            {
                return true;
            }
            return false;
        }

        public static bool IsNumeric(string input)
        {
            string pattern = "^[0-9]+$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(input);
        }

        public static Guid convertGUID(Guid? guid)
        {
            return guid ?? Guid.Empty;
        }

        public static bool CheckSDT(string input)
        {
            string pattern = @"^0\d{9,10}$";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else return false;
        }
    }
}