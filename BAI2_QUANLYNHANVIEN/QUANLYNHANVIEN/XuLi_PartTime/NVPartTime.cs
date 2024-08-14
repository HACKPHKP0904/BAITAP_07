using System;
using Models_Nhanvien;

namespace XuLi_NV
{
    public class NVPartTime : Model_NV
    {
        public decimal gioLuong { get; set; }
        public int gioLam { get; set; }

        public NVPartTime(string name, int idNV, decimal gioLuong, int gioLam)
            : base(name, idNV)
        {
            this.gioLuong = gioLuong;
            this.gioLam = gioLam;
        }

        public override decimal tinhLuong()
        {
            return gioLuong * gioLam;
        }

        public override string ToString()
        {
            return base.ToString() + $", Lương: {tinhLuong()}";
        }
    }
}
