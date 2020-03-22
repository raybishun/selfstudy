using System;

namespace NumbersConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Size_Min_Max();
            Double_Vs_Demimal();
            CheckDecimal();
              
            Console.ReadKey();
        }
        
        private static void CheckDecimal()
        {
            decimal a = 0.1M;
            decimal b = 0.2M;

            Console.WriteLine($"{a + b == 0.3M}");
            Console.WriteLine($"{a + b}");
        }

        private static void Double_Vs_Demimal()
        {
            double a = 0.1;
            double b = 0.2;

            Console.WriteLine($"{a + b == 0.3}");
            Console.WriteLine($"{a + b}");
        }

        private static void Size_Min_Max()
        {
            // Int
            Console.WriteLine($"sizeof: {sizeof(int)}");

            Console.WriteLine($"MinValue: {int.MinValue:N0}");

            Console.WriteLine($"MaxValue: {int.MaxValue:N0}");
            Console.WriteLine();

            // Double
            Console.WriteLine($"sizeof: {sizeof(double)}");

            Console.WriteLine($"MinValue: {double.MinValue:N0}");

            Console.WriteLine($"MaxValue: {double.MaxValue:N0}");
            Console.WriteLine();

            // Decimal
            Console.WriteLine($"sizeof: {sizeof(decimal)}");

            Console.WriteLine($"MinValue: {decimal.MinValue:N0}");

            Console.WriteLine($"MaxValue: {decimal.MaxValue:N0}");
            Console.WriteLine();
        }
    }
}
