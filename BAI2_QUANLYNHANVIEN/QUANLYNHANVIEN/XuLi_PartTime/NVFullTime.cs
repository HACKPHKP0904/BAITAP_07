using Models_Nhanvien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLi_NV
{
    public class NVFullTime : Model_NV
    {
        public decimal luongCung {  get; set; }
        
        public NVFullTime (string name , int iDNV, decimal luong_cung) : base(name,iDNV)
        {
            luongCung = luong_cung;
        }
        public override decimal tinhLuong()
        {
            return luongCung;
        }
        public override string ToString()
        {
            return base.ToString() + $",Lương :{tinhLuong()}";
        }
    }
}
