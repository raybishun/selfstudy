using System;

namespace NumbersConsoleApp
{
    class Program
    {
         // Casting Objects (via boxing anduUnboxing) comes with a performance cost
         // However, 'generics' (introduced in C# 2) is more efficient


        static void Main(string[] args)
        {
            // Size_Min_Max();
            // Double_Vs_Demimal();
            // CheckDecimal();
            // DynamicTypes_CS4();
            Implicity_Typed_Variables();

            Console.ReadKey();
        }

        private static void Implicity_Typed_Variables()
        {
            // Implicity-typed variables:
                // must be initialized
                // and can only be local

            var a = 'a';
            var b = "b";
            var c = 1;
            var d = 1L;
            var e = 1.618;
            var f = 1.618F;
            var g = 1.618M;
        }

        private static void DynamicTypes_CS4()
        {
            // dynamic types are only checked at runtime (not build time)

            dynamic x = "Ray";
            Console.WriteLine(x);

            // The below exception will occur at runtime
                // Microsoft.CSharp.RuntimeBinder.RuntimeBinderException: 
                // 'Cannot implicitly convert type 'string' to 'int''
            int age = x;
            Console.WriteLine(age);
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
