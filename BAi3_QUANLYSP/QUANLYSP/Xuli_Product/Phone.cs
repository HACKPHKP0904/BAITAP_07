using Abstract_SP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xuli_Product
{
    public class Phone : AbProduct
    {
        public string thuongHieu { get; set; }

        public Phone(string name, decimal price, string thuonghieu) : base(name, price)
        {
            thuongHieu = thuonghieu;
        }

        public override decimal GetPrice()
        {
            return Price;
        }
        public override string ToString()
        {
            return base.ToString() + $"Thương hiệu: {thuongHieu} , Giá : {GetPrice()}";
        }
    }
}

