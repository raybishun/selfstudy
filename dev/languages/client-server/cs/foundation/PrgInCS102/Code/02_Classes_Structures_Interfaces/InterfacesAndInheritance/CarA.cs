using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndInheritance
{
    class CarA : Car
    {
        public CarA()
        {
            BodyType = string.Empty;
            MfgDate = DateTime.MinValue;
            FuelCapacity = 0.0F;
            Console.WriteLine("CarA ctor1()...");
        }

        public CarA(DateTime mfgDate, string bodyType, float fuelCapacity)
        {
            BodyType = bodyType;
            MfgDate = mfgDate;
            FuelCapacity = fuelCapacity;
            Console.WriteLine("CarA ctor2()...");
        }

        public void FoldableSeat()
        {
            Console.WriteLine("CarA FoldableSeat()...");
        }
    }
}
