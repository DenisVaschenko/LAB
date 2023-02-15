using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class DepositeProgram
    {
        public DepositeProgram(string valute, string percent, string termine)
        {
            Valute = valute;
            Percent = percent;
            Termine = termine;
        }
        public string Valute { get; set; }
        public string Percent { get; set; }
        public string Termine { get; set; }
        public int Cash = 0;
        void AddCash(int value)
        {
            Cash += value;
        }
        void GetCash (int value)
        {
            if (Cash >= value)
            {
                Cash -= value;
            }
            else
            {
                Console.WriteLine("Not enough money");
            }
        }
    }
}
