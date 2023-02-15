namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new UndamagedShip("45");
            Console.WriteLine(ship.Condition);
            ship = ship.GedDamage();
            Console.WriteLine(ship.Condition);
            ship = ship.GedDamage();
            Console.WriteLine(ship.Condition);
        }
    }
}