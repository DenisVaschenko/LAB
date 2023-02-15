using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class WaterBuilder
    {
        public Water water(Builder builder)
        {
            builder.CreateWater();
            builder.BuildPit();
            builder.BuildFilledWater();
            builder.BuildPlants();
            builder.BuildInhabitants();
            return builder.Water;
        }
    }
}
