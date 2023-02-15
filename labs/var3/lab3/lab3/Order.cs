using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    abstract class Order
    {
        public Order(string name)
        {
            Name = name;
        }
        public string Cost { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
    }
}
