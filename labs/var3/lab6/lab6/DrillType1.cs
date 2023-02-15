using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class DrillType1 : Drill
    {
        public DrillType1(string name) : base(name)
        {

        }
        public override int GetTime()
        {
            return 5;
        }
    }
}
