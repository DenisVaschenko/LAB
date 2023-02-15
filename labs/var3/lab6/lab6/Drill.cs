using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    abstract class Drill
    {
        public Drill(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public abstract int GetTime();
    }
}
