using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Student
    {
        public Student(string name)
        {
            Name = name;
            Marks = new List<int>();
        }
        public string Name { get; set; }
        public List<int> Marks { get; set; }
        public void PassTest(int index, int mark, Module module)
        {
            if (module.PreviousModule==null || module.PreviousModule.students.Contains(this))
            {
                Console.WriteLine(module.Name + " " + module.Problems[index] + " Mark " + mark);
                if (mark >= 5) module.students.Add(this);
                Marks.Add(mark);
            }
            else
            {
                Console.WriteLine("You should pass the previous module");
            }
        }
    }
}
