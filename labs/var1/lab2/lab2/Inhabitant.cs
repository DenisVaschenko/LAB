using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Inhabitant
    {
        public Inhabitant(string name, string adress, House house)
        {
            Name = name;
            Adress = adress;
            House = house;

        }
        string Name { get; set; }
        string Adress { get; set; }
        House House { get; set; }
        public void AdressOfInhabitant()
        {
            Console.WriteLine(Name + "'s adress is " + Adress);
        }
    }
}
