using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    abstract class Worker
    {
        public Worker(string name, string building, string room, string workplace, string faculty)
        {
            Name = name;
            Building = building;
            Room = room;
            Workplace = workplace;
            Faculty = faculty;
        }
        public string Name { get; protected set; }
        public string Building { get; protected set; }
        public string Room { get; protected set; }
        public string Workplace { get; protected set; }
        public string Faculty { get; protected set; }
        public abstract List<string> GetDuties();
    }
}
