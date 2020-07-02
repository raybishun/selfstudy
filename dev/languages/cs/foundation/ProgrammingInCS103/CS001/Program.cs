using System;

namespace ProgrammingInCS103
{
    class Program
    {
        // Converting a reference type into a value type
        static void Temp(float degree)
        {
            object degreesRef = degree;
            int result = (int)(float)degreesRef;
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            Temp(32.3f);
            Console.ReadKey();
        }
    }
}
