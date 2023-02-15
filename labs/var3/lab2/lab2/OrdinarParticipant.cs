using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class OrdinarParticipant : Participant
    {
        public OrdinarParticipant(string name, string form, string school, string place) : base(name, form, school, place)
        {

        }
        public override void GetDocument()
        {
            Console.WriteLine(Name + " " + School + " " + Form + " as an ordinar participant took " + Place + " Place");
        }
    }
}
