using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Import_NV;
namespace QUANLYNHANVIEN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ImportNV nhapNV = new ImportNV();
            nhapNV.HienThiDanhSachNhanVien();
            Console.ReadLine();

        }
    }
}
