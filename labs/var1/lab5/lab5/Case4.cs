using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Case4 : Handler
    {
        public override void Handle(Receiver receiver)
        {
            if (!receiver.IsAvailable)
            {
                Console.WriteLine("No available goods");
            }
            else if (Successor != null)
            {
                Successor.Handle(receiver);
            }
        }
    }
}