using System;

namespace PolymorphismOverriding
{
    class Car
    {
        public Car()
        {
            Console.WriteLine("Car() ctor");
        }

        public virtual void Accelerate()
        {
            Console.WriteLine("Accelerate() in Car");
        }
    }
}
