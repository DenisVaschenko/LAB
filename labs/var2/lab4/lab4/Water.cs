using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Water
    {
        public Pit Pit { get; set; }
        public FilledWater FilledWater { get; set; }

        public List<Plant> Plant = new List<Plant>();
        public List<Inhabitant> Inhabitants = new List<Inhabitant>();
    }
}
