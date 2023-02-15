using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Case2 : Handler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.IsAvailable && receiver.IsMoneyEnough == 0)
            {
                Console.WriteLine("Not enough cash");
            }
            else if (Successor != null)
            {
                Successor.Handle(receiver);
            }
        }
    }
}
