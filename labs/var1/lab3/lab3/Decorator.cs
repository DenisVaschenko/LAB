using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Decorator:Car
    {
        protected Car car;
        public Decorator(string model, string color, string typeOfBody, string number, Car car) : base(model,color,typeOfBody,number)
        {
            this.car = car;
        }
    }
}
