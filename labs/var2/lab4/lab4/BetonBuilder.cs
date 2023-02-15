using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class BetonBuilder : Builder
    {
        public override void BuildPit()
        {
            this.Water.Pit = new Pit { name = "beton" };
        }
        public override void BuildFilledWater()
        {
            this.Water.FilledWater = new FilledWater();
        }
        public override void BuildInhabitants()
        {
            this.Water.Inhabitants = new List<Inhabitant>();
        }
        public override void BuildPlants()
        {
            this.Water.Plant = new List<Plant>();
        }
    }
}
