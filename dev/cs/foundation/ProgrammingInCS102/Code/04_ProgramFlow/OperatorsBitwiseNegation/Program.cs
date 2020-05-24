using System;

namespace OperatorsBitwiseNegation
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 3;
            
            string binaryString = IntToBinaryString(myInt);
            Console.WriteLine(binaryString);

            // Reverse each bit
            int bitwiseNegation = ~myInt;
            Console.WriteLine(bitwiseNegation);
        }

        static string IntToBinaryString(int value)
        {
            // Convert value of a 32-bit signed integer to it equivalent string
            // representation in a specified base (2, 8, 10, or 16)
            return Convert.ToString(value, 2);
        }
    }
}
