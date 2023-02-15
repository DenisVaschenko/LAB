using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class DestroyedShip : Ship
    {
        public DestroyedShip(string id) : base(id, "destroyed")
        {

        }
        public override Ship GedDamage()
        {
            return new DestroyedShip(Id);
        }
    }
}
