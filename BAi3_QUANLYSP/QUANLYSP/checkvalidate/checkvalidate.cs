using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkvalidate
{
    public class checkvalidate
    {
        public static decimal check_validate()
        {
            decimal number;
            while(!decimal.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Vui lòng nhập lại : ");
            }
            return number;
        }
    }
}
