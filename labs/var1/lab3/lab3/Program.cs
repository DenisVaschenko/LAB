namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Model("model1");
            car1 = new Color(car1, "green");
            car1 = new TypeOfBody(car1, "type1");
            car1 = new Number(car1, "0846");
            Console.WriteLine(car1.ModelOfCar+" "+car1.Color+" "+car1.TypeOfBody + " " + car1.Number);
        }
    }
}
