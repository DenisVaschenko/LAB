using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Laureate : Participant
    {
        public Laureate(string name, string form, string school, string place) : base(name, form, school, place)
        {

        }
        public override void GetDocument()
        {
            Console.WriteLine(Name + " " + School + " " + Form + " as a laureate took " + Place + " Place");
        }
    }
}
