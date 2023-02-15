using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    abstract class Module
    {
        public Module(List<string> problems, string name)
        {
            Problems = problems;
            Name = name;
        }
        public List<String> Problems;
        public string Name { get; set; }
        public Module PreviousModule;
        public List<Student> students = new List<Student>();
    }
}
