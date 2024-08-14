using System;
using System.Collections.Generic;
using check;
using Models_Nhanvien;
using XuLi_NV;

namespace Import_NV
{
    public class ImportNV
    {
        public List<Model_NV> DanhSachNhanVien { get;  set; }

        public ImportNV()
        {
            DanhSachNhanVien = new List<Model_NV>();
            NhapDanhSachNhanVien();
        }

        private void NhapDanhSachNhanVien()
        {
            string luaChonTiepTuc;

            do
            {
                string name = string.Empty;
                int iDNV;
                name = check.check_string.check_ten();
                Console.Write("Nhập ID của nhân viên : ");
                iDNV = check.checkvalidate.check_validate();
                Console.WriteLine("====================================================");
                Console.WriteLine("Chọn loại nhân viên:");
                Console.WriteLine("1. Nhân viên Bán Thời Gian");
                Console.WriteLine("2. Nhân viên Toàn Thời Gian");
                Console.WriteLine("Nhập 1 hoặc 2 vào : ");
                string luaChon = check.checkvalidate.check_luachon();
                switch (luaChon)
                {
                    case "1":
                        Console.WriteLine("Bạn đã Chọn Nhân Viên Bán Thời Gian");
                        Console.Write("Mời bạn nhập lương theo giờ: ");
                        decimal gioLuong = decimal.Parse(Console.ReadLine());
                        Console.Write("Mời bạn nhập số giờ làm: ");
                        int gioLam = int.Parse(Console.ReadLine());
                        NVPartTime partTimeNV = new NVPartTime(name, iDNV, gioLuong, gioLam);
                        DanhSachNhanVien.Add(partTimeNV);
                        break;
                    case "2":
                        Console.WriteLine("Bạn đã chọn Nhân Viên Toàn Thời Gian");
                        Console.WriteLine("Mời bạn nhập lương cứng: ");
                        decimal luongCung = decimal.Parse(Console.ReadLine());
                        NVFullTime fullTimeNV = new NVFullTime(name, iDNV, luongCung);
                        DanhSachNhanVien.Add(fullTimeNV);
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }

                Console.WriteLine("Bạn có muốn nhập thêm nhân viên khác không? (y/n)");
                luaChonTiepTuc = Console.ReadLine().ToLower();

            } while (luaChonTiepTuc == "y");

        }

        public void HienThiDanhSachNhanVien()
        {
            Console.WriteLine("Danh sách nhân viên đã nhập:");
            foreach (var nv in DanhSachNhanVien)
            {
                Console.WriteLine(nv.ToString());
            }
        }
    }
}
