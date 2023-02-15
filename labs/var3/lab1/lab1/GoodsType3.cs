using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class GoodsType3 : Goods
    {
        public GoodsType3(string title, string department, string cost) : base(title, department, cost, "продаються вроздріб та оптом")
        {

        }
    }
}
