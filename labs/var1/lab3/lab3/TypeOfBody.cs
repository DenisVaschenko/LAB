using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class TypeOfBody : Decorator
    {
        public TypeOfBody(Car c, string typeOfBody) : base(c.ModelOfCar,c.Color, typeOfBody, c.Number,c)
        {

        }
    }
}
