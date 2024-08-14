using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace checkvalidate
{
    public class checkstrin
    {
        public static string check_ten(string loaiTen)
        {
            string name;
            bool isValid;

            do
            {
                Console.WriteLine($"Nhập {loaiTen} ");
                name = Console.ReadLine();
                isValid = !string.IsNullOrWhiteSpace(name);

                if (!isValid)
                {
                    Console.WriteLine($"{loaiTen} không hợp lệ. Vui lòng nhập lại (không được để trống).");
                }
            } while (!isValid);

            return name;
        }

        public static string check_hang()
        {
            string brand;
            bool isValid;

            do
            {
                Console.WriteLine("Nhập hãng sản phẩm:");
                brand = Console.ReadLine();
                isValid = !string.IsNullOrWhiteSpace(brand) && IsAllLetters(brand);

                if (!isValid)
                {
                    Console.WriteLine("Hãng không hợp lệ. Vui lòng nhập lại (không được chứa số và không để trống).");
                }
            } while (!isValid);

            return brand;
        }
        private static bool IsAllLetters(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
