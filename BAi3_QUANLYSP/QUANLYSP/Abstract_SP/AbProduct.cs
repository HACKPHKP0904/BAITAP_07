using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_SP
{
    public abstract class AbProduct
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public AbProduct(string name , decimal price) 
        { 
            Name = name;
            Price = price;
        }

        public abstract decimal GetPrice();

        public override string ToString()
        {
            return $"Tên Sản Phẩm : {Name}, Giá : {Price}";
        }
    }
}
