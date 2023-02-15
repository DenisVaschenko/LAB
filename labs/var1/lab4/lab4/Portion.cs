using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Portion
    {
        public Portion(Meat meat, Garnish garnish)
        {
            Meat = meat;
            Garnish = garnish;
        }
        public Meat Meat { get; set; }
        public Garnish Garnish { get; set; }
    }
}
