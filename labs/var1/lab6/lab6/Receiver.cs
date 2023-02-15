using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Receiver
    {
        public Receiver(bool doKnow1, bool doKnow2)
        {
            DoKnow1 = doKnow1;
            DoKnow2 = doKnow2;
        }
        public bool DoKnow1 { get; set; }
        public bool DoKnow2 { get; set; }
    }
}
