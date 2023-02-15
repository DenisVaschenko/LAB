using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    abstract class Builder
    {
        public Water Water { get; protected set; }
        public void CreateWater()
        {
            Water = new Water();
        }
        public abstract void BuildPit();
        public abstract void BuildFilledWater();
        public abstract void BuildInhabitants();
        public abstract void BuildPlants();
    }
}
