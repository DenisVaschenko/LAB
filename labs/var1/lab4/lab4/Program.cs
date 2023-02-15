namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitchen kitchen1 = new Kitchen();
            Garnish garnish1 = new Garnish("garnish1");
            kitchen1.AddGarnish(garnish1,5);
            Garnish garnish2 = new Garnish("garnish2");
            kitchen1.AddGarnish(garnish2, 7);
            Meat meat1 = new Meat("meat1");
            kitchen1.AddMeat(meat1, 11);
            int i = 0;
            while (i<kitchen1.meats.Count() && i < kitchen1.garnishes.Count())
            {
                kitchen1.AddPortion(kitchen1.meats[i], kitchen1.garnishes[i]);
            }
            foreach(Portion p in kitchen1.portions)
            {
                Console.WriteLine(p.Meat.Title + " " + p.Garnish.Title);
            }
        }
    }
}
