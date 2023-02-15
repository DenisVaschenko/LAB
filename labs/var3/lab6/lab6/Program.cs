using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Drill d = new DrillType2("name1");
            Console.WriteLine(d.GetTime());
        }
    }
}
