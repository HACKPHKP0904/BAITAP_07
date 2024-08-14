using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models_HinhHoc;
using Abstracst;
using Check_Validate;
using System.Data;
namespace XulLiTinhToan
{
    public class XuLiTinhToan : Shape
    {
        private double banKinh;
        private float chieuDai;
        private float chieuRong;
        const double PI = 3.14;
        public void nhapBanKinh()
        {
            Console.Write("Mời bạn nhập bán kính :");
            banKinh = checkvalidate.checkValidate();
        }
        public  void nhapChieuDaiRong()
        {
            Console.WriteLine("Mời bạn nhập chiều dài :");
            chieuDai = checkvalidate.checkValidate();
            Console.WriteLine("Mời bạn nhập chiều rộng :");
            chieuRong = checkvalidate.checkValidate();
        }
        public  static void  luaChon()
        {
           
            //
            string luaChon = "";
            XuLiTinhToan xuLiTinhToan = new XuLiTinhToan();

            Console.WriteLine("Bài tập quản lí hình học");
            Console.WriteLine("--1.Quản lí hình tròn ");
            Console.WriteLine("--2.Quản lí hình chữ nhật ");
            Console.WriteLine("Mời bạn nhập lựa chọn :");
            luaChon = Check_Validate.checkluachon.check_LuaChon();
            switch (luaChon)
            {
                case "1":
                    Console.WriteLine("Bạn đã chọn quản lí hình tròn");
                    xuLiTinhToan.nhapBanKinh();
                    Console.WriteLine("Kết quả bạn cần tìm ta có");
                    xuLiTinhToan.chuVi();
                    xuLiTinhToan.dienTich();
                    break;
                case "2":
                    Console.WriteLine("Bạn đã chọn quản lí hình chữ nhật");
                    xuLiTinhToan.nhapChieuDaiRong();
                    Console.WriteLine("Kết quả bạn cần tìm ta có");
                    xuLiTinhToan.chuVi();
                    xuLiTinhToan.dienTich();
                    break;
            }
        }
        public override double chuVi()
        {
            if(banKinh >0)
            {
                double chuViHinhTron = 2 * PI * banKinh;
                Console.WriteLine("Chu vi hình tròn được tính là {0}",chuViHinhTron);
                return chuViHinhTron;
            }else if(chieuDai >0 || chieuRong > 0)
            {
                double chuViHinhChuNhat = 2 * (chieuRong + chieuDai);
                Console.WriteLine("Chu vi hình chữ nhật là {0}",chuViHinhChuNhat);
                return chuViHinhChuNhat;
            }
            else
            {
                throw new InvalidOperationException("Các thông số chưa được nhập đúng!");
            }
        }
        public override double dienTich()
        {
            if (banKinh > 0)
            {
                double dienTichHinhTron = PI * banKinh * banKinh;
                Console.WriteLine("Diện tích hình tròn được tính là {0}", dienTichHinhTron);
                return dienTichHinhTron;
            }
            else if (chieuDai > 0 || chieuRong > 0)
            {
                double dienTichHinhChuNhat = chieuDai * chieuRong;
                Console.WriteLine("Diện tích hình chữ nhật là {0}", dienTichHinhChuNhat);
                return dienTichHinhChuNhat;
            }
            else
            {
                throw new InvalidOperationException("Các thông số chưa được nhập đúng!");
            }
        }
    }
}
