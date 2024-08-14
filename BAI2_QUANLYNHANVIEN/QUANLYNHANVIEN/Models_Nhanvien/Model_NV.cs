using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models_Nhanvien
{
    public abstract class Model_NV
    {
        public string Name { get; set; }
        public int IdNV { get; set; }

        protected Model_NV(string name, int idNV)
        {
            Name = name;
            IdNV = idNV;
        }

        // hàm tính lương
        public abstract decimal tinhLuong();

        // hàm để liệt kê nhân viên
        public override string ToString()
        {
            return $"Nhân viên: {IdNV}, Tên: {Name}";
        }
    }
}
