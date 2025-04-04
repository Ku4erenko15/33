using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
{
    class Kit:Item
    {

        public List<Product> Products { get; set; }

        public Kit(string name, decimal price, List<Product> products)
            : base(name, price) => Products = products;

        public override void Print()
        {
            Console.WriteLine($"");
        }

    }
}
