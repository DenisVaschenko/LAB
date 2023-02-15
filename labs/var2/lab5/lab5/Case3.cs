using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Case3 : Operator
    {
        public override void Handle(User user)
        {
            if (user.IsCase3 == true)
            {
                Console.WriteLine("Part of the money was spended on stock");
            }
        }
    }
}