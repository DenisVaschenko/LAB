using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Case2 : Handler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.DoKnow2)
            {
                Console.WriteLine("senior operator answered the question");
            }
            else if (Successor != null)
            {
                Successor.Handle(receiver);
            }
        }
    }
}
