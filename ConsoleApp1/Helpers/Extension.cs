using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1.Helpers
{
    public static class Extension
    {
        public static bool CheckEmail(this string email)
        {
            int count = 0;
            foreach ( var item in email)
            {
                if(item == '@')
                {
                    count ++;
                }

                if (item == 2)
                {
                    break;
                }
            }

            if(count == 1)
            {
                return true;
            }
            return false;
        }


        public static bool CheckTrim(this string str , string pattern)
        {
            return Regex.IsMatch(str, pattern);
        }


        public static string GetFullData(this Person person)
        {
            return $"{person.Surname} - {person.Name}";
        }

        public static int GetMultiplyArray(this int[] number)
        {
            int multiply = 1;
            foreach ( var item in number)
            {
                multiply *= item;
            }

            return multiply; 
        }
    }



}
