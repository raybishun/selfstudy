using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndInheritance
{
    class Car
    {
        public DateTime MfgDate { get; set; }
        public string BodyType { get; set; }
        public float FuelCapacity { get; set; }
        public void ImplementBrake()
        {
            Console.WriteLine("Base: ImplementBrake()...");
        }
        public void ImplementAccelerator()
        {
            Console.WriteLine("Base: ImplementAccelerator()...");
        }
    }
}
