namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("name1");
            Module module1 = new Module1(new List<string>() { "test1", "test2", "test3" }, "module1");
            Module module2 = new Module2(new List<string>() { "test4", "test5", "test6" }, "module2");
            module2.PreviousModule = module1;
            student.PassTest(2, 6, module2);
            student.PassTest(2, 8, module1);
            student.PassTest(2, 4, module2);
        }
    }
}
