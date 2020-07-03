using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndInheritance
{
    class CarB : Car
    {
        public CarB()
        {
            base.BodyType = string.Empty;
            MfgDate = DateTime.MinValue;
            FuelCapacity = 0.0F;
        }

        public CarB(DateTime mfgDate, string bodyType, float fuelCapacity)
        {
            BodyType = bodyType;
            MfgDate = mfgDate;
            FuelCapacity = fuelCapacity;
            Console.WriteLine("CarB ctor2()...");
        }

        public void RoofTopExtendable()
        {
            Console.WriteLine("CarB RoofTopExtendable()...");
        }
    }
}
