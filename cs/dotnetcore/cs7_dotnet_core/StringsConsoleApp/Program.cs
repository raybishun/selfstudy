using System;

namespace StringsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // String_Char_Array();
            // String_Split();
            // String_IndexOf_and_Substring();
            // String_Contains();
            String_StartsWith();

            Console.ReadLine();
        }

        private static void String_StartsWith()
        {
            string fullName = "ray bishun";
            bool find = fullName.StartsWith('R'); // returns False, is case sensitive
            Console.WriteLine(find);
        }

        private static void String_Contains()
        {
            string fullName = "ray bishun";
            bool find = fullName.Contains('a');
            Console.WriteLine(find);
        }

        private static void String_IndexOf_and_Substring()
        {
            string fullName = "ray bishun";
            int indexOfTheSpace = fullName.IndexOf(' ');
            string firstName = fullName.Substring(0, indexOfTheSpace);
            string lastName = fullName.Substring(indexOfTheSpace);
            Console.WriteLine($"{lastName}, {firstName}");
        }

        private static void String_Split()
        {
            string fullName = "ray bishun";
            string[] elements = fullName.Split(' ');
            Console.WriteLine(elements[0]);
        }

        private static void String_Char_Array()
        {
            string name = "ray";
            Console.WriteLine(name[0]);
        }
    }
}
