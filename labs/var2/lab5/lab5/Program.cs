namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(true, false, true);
            Case1 case1 = new Case1();
            Case2 case2 = new Case2();
            Case3 case3 = new Case3();
            case1.Handle(user);
            case2.Handle(user);
            case3.Handle(user);
        }
    }
}
