namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver(true, false);
            Handler Case1 = new Case1();
            Handler Case2 = new Case2();
            Handler Case3 = new Case3();
            Case1.Successor = Case2;
            Case2.Successor = Case3;
            Case1.Handle(receiver);
        }
    }
}
