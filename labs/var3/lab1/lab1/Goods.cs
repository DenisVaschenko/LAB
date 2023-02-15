using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    abstract class Goods
    {
        public Goods(string title, string department, string cost, string waysToBuy)
        {
            Title = title;
            Department = department;
            Cost = cost;
            WaysToBuy = waysToBuy;
        }
        public string Title { get; set; }
        public string Department { get; set; }
        public string Cost { get; set; }
        public string WaysToBuy { get; set; }
    }
}
