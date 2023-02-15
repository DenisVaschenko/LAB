using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Student
    {
        public Student(string name)
        {
            Name = name;
            HasPassedExam = false;
        }
        public string Name { get; set; }
        public bool HasPassedExam { get; set; }
        public void PassExam()
        {
            HasPassedExam = true;
        }
        public void Display()
        {
            Console.WriteLine(Name + " ");
            if (HasPassedExam)
            {
                Console.Write("This student has passed exam");
            }
            else
            {
                Console.Write("This student has not passed exam");
            }
        }
    }
}
