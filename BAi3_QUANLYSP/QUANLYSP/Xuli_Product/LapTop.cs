using Abstract_SP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xuli_Product
{
    public class LapTop : AbProduct
    {
        public string thuongHieu {  get; set; }

        public LapTop(string name , decimal price , string thuonghieu) : base(name,price)
        {
            thuongHieu = thuonghieu;
        }

        public override decimal GetPrice()
        {
            return Price; 
        }

        public override string ToString()
        {
            return base.ToString() + $"thương hiệu : {thuongHieu}, giá : {GetPrice()}";
        }
    }
}
