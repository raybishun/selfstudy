using System;

namespace PolymorphismOverriding
{
    class Suzuki : Car
    {
        public Suzuki()
        {
            Console.WriteLine("Suzuki() ctor");
        }

        public void Accelerate()
        {
            Console.WriteLine("Accelerate() in Suzuki");
        }

        // Suzuki.Accelerate() hides inherited member
        // Car.Accelerate(). To make the current member override 
        // that implementation, add the 'override' keyword. Otherwise
        // add the 'new' keyword.
    }
}
