using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Receiver
    {
        public Receiver(bool isAvailable, int isMoneyEnough)
        {
            IsAvailable = isAvailable;
            IsMoneyEnough = isMoneyEnough;
        }
        public bool IsAvailable { get; set; }
        public int IsMoneyEnough { get; set; }
    }
}
