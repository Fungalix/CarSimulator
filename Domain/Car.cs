using System;
using System.Collections.Generic;
using System.Text;

namespace CarSimulator.Domain
{
    class Car
    {
        string brand;
        string model;
        ushort velocity;

        public Car(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }
    }
}
