using Abstract_SP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xuli_Product
{
    public class Electronics : AbProduct
    {
        public string Loai { get; set; }

        public Electronics(string name, decimal price, string loai)
            : base(name, price)
        {
            Loai = loai;
        }

        public override decimal GetPrice()
        {
            // Implement any additional calculations for electronics price
            return Price * 1.15m; // Example: adding 15% tax
        }

        public override string ToString()
        {
            return base.ToString() + $", Loại: {Loai},  Giá: {GetPrice()}";
        }
    }
}
