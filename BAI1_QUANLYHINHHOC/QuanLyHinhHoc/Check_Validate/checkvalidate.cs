using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Validate
{
    public class checkvalidate
    {
        public  static float checkValidate() 
        {
            
            float number;
            while(!float.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Vui lòng nhập lại");
            }
            return number; 
        }
    }
}
