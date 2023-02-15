using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Case3 : Handler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.IsAvailable && receiver.IsMoneyEnough == 2)
            {
                Console.WriteLine("Too much cash");
            }
            else if (Successor != null)
            {
                Successor.Handle(receiver);
            }
        }
    }
}
