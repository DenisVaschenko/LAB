using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    abstract class Handler
    {
        public Handler Successor;
        public abstract void Handle(Receiver receiver);
    }
}
