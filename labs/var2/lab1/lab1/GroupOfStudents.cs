using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class GroupOfStudents
    {
        public List<Student> Students = new List<Student>();
        public void Display()
        {
            foreach(var x in Students)
            {
                Console.Write(x.Name + " ");
                if (x.HasPassedExam)
                {
                    Console.WriteLine("This student has passed exam");
                }
                else
                {
                    Console.WriteLine("This student has not passed exam");
                }
            }
        }
        public void AddStudent(Student student)
        {
            if (!Students.Contains(student))
            {
                Students.Add(student);
            }
            else
            {
                Console.WriteLine("This student has already been added");
            }
        }
    }
}
