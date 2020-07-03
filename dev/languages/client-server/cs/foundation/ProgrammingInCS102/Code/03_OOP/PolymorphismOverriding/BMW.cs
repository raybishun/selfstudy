using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismOverriding
{
    class BMW : Car
    {
        public BMW()
        {
            Console.WriteLine("BMW() ctor");
        }

        public override void Accelerate()
        {
            //base.Accelerate();
            Console.WriteLine("Accelerate() in BMW");
        }

    }
}
