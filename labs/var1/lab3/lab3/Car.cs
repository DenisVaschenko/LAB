using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    abstract class Car
    {
        public Car(string modelOfCar, string color, string typeOfBody, string number)
        {
            ModelOfCar = modelOfCar;
            Color = color;
            TypeOfBody = typeOfBody;
            Number = number;
        }
        public string ModelOfCar { get; set; }
        public string Color { get; set; }
        public string TypeOfBody { get; set; }
        public string Number { get; set; }
    }
}
