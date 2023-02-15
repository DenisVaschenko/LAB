using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class UndamagedShip : Ship
    {
        public UndamagedShip(string id) : base(id, "undamaged")
        {

        }
        public override Ship GedDamage()
        {
            return new DamagedShip(Id);
        }
    }
}
