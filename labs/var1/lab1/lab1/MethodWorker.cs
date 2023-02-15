using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class MethodWorker: Worker
    {
        public MethodWorker() : base(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine())
        {

        }
        public override List<string> GetDuties()
        {
            List<string> duties = new List<string>();
            duties.Add("Analysis");
            return duties;
        }
    }
}
