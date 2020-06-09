using System;
using System.Text;

namespace Ranges
{
    class Program
    {
        static void Main(string[] args)
        {
            RangeDemo();
        }

        static void RangeDemo()
        {
            string[] letters = new string[]
            { 
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
                "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
                "U", "V", "W", "X", "Y", "Z"
            };

            StringBuilder sb = new StringBuilder();
            
            Range range = 1..5;

            Range range1 = 10..^2;

            Range range2 = 10..;

            foreach (var item in letters[range2])
            {
                sb.Append($"{item} ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
