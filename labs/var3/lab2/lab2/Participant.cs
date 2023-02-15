using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    abstract class Participant
    {
        public Participant(string name, string form, string school, string place)
        {
            Name = name;
            Form = form;
            School = school;
            Place = place;
        }
        public string Name { get; set; }
        public string Form { get; set; }
        public string School { get; set; }
        public string Place { get; set; }
        public abstract void GetDocument();
    }
}
