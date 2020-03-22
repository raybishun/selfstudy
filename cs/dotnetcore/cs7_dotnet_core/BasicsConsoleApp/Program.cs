using System;

namespace BasicsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NameOf_CS6();
            DigitalSeparators_CS7();

            Console.ReadKey();
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

        private static void NameOf_CS6()
        {
            double myDouble = 1.618;
            Console.WriteLine($"{nameof(myDouble)}");
        }

    }
}
