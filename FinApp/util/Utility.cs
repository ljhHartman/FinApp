using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinApp.util
{
    class Utility
    {

        public static double StringToDouble(String str)
        {
            // Convert String to Doube and alos remove "" from String
            String str1 = str.Replace("\"", "");
            Double get_number;

            if (Double.TryParse(str1, out get_number))
            {
                Console.WriteLine($"Parsed {str1}, to {get_number}");
            }
            else
            {
                Console.WriteLine($"Cant't Parse {str1}");
                get_number = 0;
            }
            return get_number;
        }


    }
}
