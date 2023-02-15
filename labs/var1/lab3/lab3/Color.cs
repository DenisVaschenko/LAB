using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Color : Decorator
    {
        public Color(Car c, string color) : base(c.ModelOfCar,color,c.TypeOfBody,c.Number,c)
        {
        }
        
    }
}
