using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Number : Decorator
    {
        public Number(Car c, string number) : base(c.ModelOfCar, c.Color, c.TypeOfBody, number, c)
        {
        }
    }
}
