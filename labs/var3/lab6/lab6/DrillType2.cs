using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class DrillType2 : Drill
    {
        public DrillType2(string name) : base(name)
        {

        }
        public override int GetTime()
        {
            return 10;
        }
    }
}
