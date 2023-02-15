namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupOfStudents group = new GroupOfStudents { };
            Student student1 = new Student("name1");
            Student student2 = new Student("name2");
            student2.PassExam();
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.Display();
        }
    }
}
