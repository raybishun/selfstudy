using System;

namespace PolymorphismOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            // ================================================================
            // New up Ferrari and Suzuki as a Car
            // ================================================================
            Car ferrari = new Ferrari();
            ferrari.Accelerate();

            Console.WriteLine("-----");

            Car suzuki = new Suzuki();
            suzuki.Accelerate();

            Console.WriteLine("-----");
            Console.WriteLine("-----");

            // ================================================================
            // New up Ferrari as a Ferrari, and new up Suzuki as a Suzuki
            // ================================================================
            Ferrari ferrari2 = new Ferrari();
            ferrari2.Accelerate();

            Console.WriteLine("-----");

            Suzuki suzuki2 = new Suzuki();
            suzuki2.Accelerate();

            // ================================================================
            // Takeaway: The Car (base) ctor was called for all of the above!!!
            // ================================================================

            Console.WriteLine("-----");
            Console.WriteLine("-----");

            // ================================================================
            // New up BWM
            // ================================================================
            Car bmw = new BMW();
            bmw.Accelerate();

            BMW bmw2 = new BMW();
            bmw.Accelerate();
        }
    }
}
