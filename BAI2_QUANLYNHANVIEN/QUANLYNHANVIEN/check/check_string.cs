using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace check
{
    public class check_string
    {
        public static string check_ten()
        {
            string name = string.Empty;
            while(true)
            {
                Console.Write("Nhập tên nhân viên : ");
                name = Console.ReadLine();

                if (!string.IsNullOrEmpty(name) && name.All(char.IsLetter)) 
                {
                    break;
                }
                Console.WriteLine("TÊN KHÔNG HỢP LỆ . VUI LÒNG NHẬP LẠI TÊN ");
            }
            return name;
        }
    }
}
