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
            string pattern = @"[\p{S}]";

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


    }
}