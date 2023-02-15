using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class AdministrativeWorker: Worker
    {
        public AdministrativeWorker() : base(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine())
        {

        }
        public override List<string> GetDuties()
        {
            List<string> duties = new List<string>();
            duties.Add("Making schedule");
            return duties;
        }
    }
}
