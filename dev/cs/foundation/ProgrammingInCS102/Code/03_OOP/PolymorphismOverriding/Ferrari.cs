using System;

namespace PolymorphismOverriding
{
    class Ferrari : Car
    {
        public Ferrari()
        {
            Console.WriteLine("Ferrari() ctor");
        }

        public void Accelerate()
        {
            Console.WriteLine("Accelerate() in Ferrari");
        }

        // Ferrari.Accelerate() hides inherited member
        // Car.Accelerate(). To make the current member override 
        // that implementation, add the 'override' keyword. Otherwise
        // add the 'new' keyword.
    }
}
