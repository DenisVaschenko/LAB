using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class House
    {
        public House(string houseAdress)
        {
            HouseAdress = houseAdress;
        }
        string HouseAdress { get; set; }
        public List<Inhabitant> inhabitants = new List<Inhabitant>();
        public void AddInhabitant(string name, string adress)
        {
            inhabitants.Add(new Inhabitant(name, adress, this));
        }
        public void NumberOfInhabitants()
        {
            Console.WriteLine("In this house(adress of house: " + HouseAdress + ") " + inhabitants.Count() + " inhabitants lives");
        }
    }
}
