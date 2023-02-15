using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class GoodsType2 : Goods
    {
        public GoodsType2(string title, string department, string cost) : base(title, department, cost, "продаються оптом")
        {

        }
    }
}
