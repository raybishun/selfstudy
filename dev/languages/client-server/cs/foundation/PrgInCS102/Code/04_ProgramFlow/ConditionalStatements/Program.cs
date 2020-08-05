using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Switch_Example();
        }

        static void Switch_Example()
        {
            string input;

            do
            {
                Console.Write("Enter a character: ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "a":
                    case "e":
                    case "i":
                    case "o":
                    case "u":
                        Console.WriteLine($"\tThank you for vowel: {input}");
                        break;
                    default:
                        break;
                }

            } while (input != "x");

            
        }
    }
}
