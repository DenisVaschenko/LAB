namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Goods good1 = new GoodsType1("name1", "dep1", "123");
            Console.WriteLine(good1.WaysToBuy);
        }
    }
}
