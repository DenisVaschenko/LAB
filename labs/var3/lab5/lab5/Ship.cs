using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    abstract class Ship
    {
        public Ship(string id, string condition)
        {
            Id = id;
            Condition = condition;
        }
        public string Id { get; set; }
        public string Condition { get; set; }
        public abstract Ship GedDamage();
    }
}
