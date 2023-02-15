using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class DamagedShip : Ship
    {
        public DamagedShip(string id) : base(id, "damaged")
        {

        }
        public override Ship GedDamage()
        {
            return new DestroyedShip(Id);
        }
    }
}
