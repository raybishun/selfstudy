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
            // String_StartsWith();
            // String_Replace();
            // String_Concat();
            // String_Join();
            String_Empty();

            Console.ReadLine();
        }

        private static void String_Empty()
        {
            string value = "";

            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("The string is empty, \"\" or null.");
            }


            string value2 = string.Empty;

            if (string.IsNullOrEmpty(value2))
            {
                Console.WriteLine("*** NOTE: string.Empty DOES NOT ALLOCATE MEMORY - Use this instead of string value = \"\" ***");
            }
        }

        private static void String_Join()
        {
            string firstName = "ray";
            string lastName = "bishun";

            string fullName = string.Join(' ', firstName, lastName);
            Console.WriteLine(fullName);
        }

        private static void String_Concat()
        {
            string firstName = "ray ";
            string lastName = "bishun";

            string fullName = string.Concat(firstName, lastName);
            Console.WriteLine(fullName);
        }

        private static void String_Replace()
        {
            string fullName = "ray bishun";
            string newName = fullName.Replace("ray", "roy");
            Console.WriteLine(newName);

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
