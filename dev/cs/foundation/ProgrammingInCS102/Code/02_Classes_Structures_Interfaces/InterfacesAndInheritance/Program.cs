using System;

namespace InterfacesAndInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            CarA carA = new CarA();
            carA.ImplementAccelerator();
            carA.ImplementBrake();
            carA.FoldableSeat();

            CarB carB = new CarB();
            carB.ImplementAccelerator();
            carB.ImplementBrake();
            carB.RoofTopExtendable();
        }
    }
}
