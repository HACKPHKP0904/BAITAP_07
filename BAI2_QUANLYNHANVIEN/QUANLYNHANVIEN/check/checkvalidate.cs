using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check
{
    public class checkvalidate
    {
        public static int check_validate()
        {
            int number;
            while(!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("NHẬP SAI . VUI LÒNG NHẬP LẠI");
            }
            return number;
        }

        public static string check_luachon()
        {
            string luaChon = "";
            bool isluaChon = false;
            while (!isluaChon)
            {
                luaChon = Console.ReadLine();
                if (luaChon == "1" || luaChon == "2")
                {
                    isluaChon = true;
                }
                else
                {
                    Console.WriteLine("Bạn đã chọn khác lựa chọn 1 hoặc 2 . CHỌN LẠI :");
                }
            }
            return luaChon;
        }
    }
}
