using Abstract_SP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Xuli_Product
{
    public class Book : AbProduct
    {
        public string tacGia { get; set; }

        public Book(string name, decimal price, string tacgia)
            : base(name, price)
        {
            tacGia = tacgia;
        }

        public override decimal GetPrice()
        {
            
            return Price;
        }

        public override string ToString()
        {
            return base.ToString() + $", Tác Giả: {tacGia}, Giá: {GetPrice()}";
        }
    }
}
