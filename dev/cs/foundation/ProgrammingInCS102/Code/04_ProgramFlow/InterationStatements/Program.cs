using System;

namespace InterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            For_Example_With_Break();
            For_Example_With_Continue();
            For_Example_With_Goto();
            For_Example_With_Blanks();
            Modulus_Operator();
            While_Example();
        }

        static void For_Example_With_Break()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    // Exit loop if 5
                    break;
                }

                Console.WriteLine(i);
            }

            Console.WriteLine();
        }
        static void For_Example_With_Continue()
        {
            for (int i = 0; i < 10; i++)
            {
                // Skip 5
                if (i == 5)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            Console.WriteLine();
        }
        static void For_Example_With_Goto()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    // Goto the GoHandle5 label
                    goto GoHandle5;
                }

                Console.WriteLine(i);
            }

            GoHandle5:
            Console.WriteLine($"Five has been handled...");

            Console.WriteLine();
        }
        static void For_Example_With_Blanks()
        {
            // No initializer; no condition; no iterator
            //for (; ;)
            //{
            //    // Do something repeatedly
            //}

            Console.WriteLine();
        }
        static void Modulus_Operator()
        {
            for (int i = 0; i < 10; i++)
            {
                // Get only odd numbers
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();
        }
        static void While_Example()
        {
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
