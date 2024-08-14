using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Validate
{
    public class checkluachon
    {
        public static string check_LuaChon()
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
                    Console.Write("Bạn đã nhập sai . Vui lòng nhập lại : ");
                }
            }
            return luaChon;
        }
    }
}
