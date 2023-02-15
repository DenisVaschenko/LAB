using System;
namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House("house1");
            house1.AddInhabitant("name1", "adress1");
            house1.AddInhabitant("name2", "adress2");
            house1.AddInhabitant("name3", "adress3");
            house1.AddInhabitant("name4", "adress4");
            house1.inhabitants[0].AdressOfInhabitant();
            house1.NumberOfInhabitants();
        }
    }
}
