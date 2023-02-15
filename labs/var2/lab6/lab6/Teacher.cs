using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Teacher
    {
        public string name;
        public Work currentWork;
        public void StartToExamine(Work work)
        {
            currentWork = work;
            work.Teacher = this;
        }
        public void StopToExamine(Work work)
        {
            if (work == currentWork)
            {
                work.Status = true;
                work.Teacher = null;
                currentWork = null;
            }
        }
    }
}
