using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class GoodsType1 : Goods
    {
        public GoodsType1(string title, string department, string cost) : base (title, department, cost, "продаються вроздріб")
        {

        }

    }
}
