using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Case1 : Handler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.IsAvailable && receiver.IsMoneyEnough == 1)
            {
                Console.WriteLine("Operation done succesfull");
            } 
            else if (Successor != null)
            {
                Successor.Handle(receiver);
            }
        }
    }
}
