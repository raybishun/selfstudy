using System;

namespace NumbersConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Size_Min_Max();
            //Double_Vs_Demimal();
            //CheckDecimal();
            //DigitalSeparators_CS7();
            Division_vs_Modulus();

            Console.ReadKey();
        }

        private static void Division_vs_Modulus()
        {
            Console.WriteLine($"5.0 / 3 = {5.0 / 3}");

            Console.WriteLine($"5.0 / 3 has a remainder of: {5.0 % 3}");


            Console.Write("Return only even numbers: ");

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        private static void DigitalSeparators_CS7()
        {
            // Base10
            int decimalNotation = 1_000_000;

            // Leading digital separator requires C# 7.2 
            // Base2
            // int binaryNotation = 0b_1111_0100_0010_0100_0000;

            // Base16
            int hexNotation = 0xF_4240;
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
