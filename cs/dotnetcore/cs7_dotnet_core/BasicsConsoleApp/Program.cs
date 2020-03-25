using System;
using System.Collections;
using System.IO;

// Introduced in C# 6, 'using static' can be used to further shorten statements, i.e.:
// using static System.Console;

namespace BasicsConsoleApp
{
    class Program
    {
        // Casting Objects (via boxing and unboxing) comes with a performance cost
        // However, 'generics' (introduced in C# 2) is more efficient
        // Reference Types - point to where the value is stored in memory; can have a 'null' literal value
        // Value Types - must have a value (but can also be 'nullable')

        // Disaster #1 caused by poor coding practice: use {} in if statements - https://gotofail.com/
        // Disaster #2 caused by poor coding practice: rounding error: http://www-users.math.umn.edu/~arnold//disasters/

        static void Main(string[] args)
        {
            // NameOf_CS6();
            // DynamicTypes_CS4();
            // Implicity_Typed_Variables();
            // Type_Defaults();
            // Nullable_Type();
            // Null_Coalescing_Operator();
            // Unary_Binary_Ternary();
            // Patten_Matching_If_Statement_CS7();
            // Switch_Case();
            // Pattern_Matching_Switch_Case_CS7();
            // Iterating_With_While();
            // Iterating_With_ForEach();
            // IEnumerator_In_Action();
            // Implicit_Casting();
            Explicit_Casting();


            Console.ReadKey();
        }

        private static void Explicit_Casting()
        {
            double a = 100.00;
            int b = (int)a;
            Console.WriteLine($"{b}\n");

            long e = 10;
            int f = (int)e;
            Console.WriteLine($"e is {e} and f is {f}");

            e = long.MaxValue;
            f = (int)e;
            Console.WriteLine($"e is {e:N} and f is {f}"); // f is -1
        }

        private static void Implicit_Casting()
        {
            int a = 100;
            double b = a;
            Console.WriteLine(b);

            // Results in:
            // "Cannot implicitly convert type 'double' to 'int'.
            // An explicit conversion exists (are you missing a cast?)"
            //double x = 100.25;
            //int y = x; 
            //Console.WriteLine(y);
        }

        private static void IEnumerator_In_Action()
        {
            // The below is what foreach would actually implement

            string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            IEnumerator e = days.GetEnumerator();
            while (e.MoveNext())
            {
                // Results in "Property or indexer IEnumerator.Current cannot be assigned to -- it is read-only"
                // (this is due to the use of an iterator)
                // e.Current = "something else"; 

                string day = (string)e.Current; // The current item is read-only
                Console.WriteLine($"{day}");
            }
        }

        private static void Iterating_With_ForEach()
        {
            // foreach items are read-only
            // foreach only works with types that implement IEnumerabl
            // See IEnumerator_In_Action() method above to understand why...
            string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            foreach (var item in days)
            {
                Console.WriteLine(item);
            }
        }

        private static void Iterating_With_While()
        {
            int i = 1;
            while (i <= 3)
            {
                Console.WriteLine($"{i} ");
                i++;
            }


            int rndNumber = new Random().Next(1, 3);
            Console.WriteLine($"My random number is: {rndNumber}");
            int guess = 0;
            
            do
            {
                Console.Write("Guess my number: ");
                guess = Convert.ToInt32(Console.ReadLine());

            } while (rndNumber != guess);

            Console.WriteLine("You guessed it...");
        }

        private static void Pattern_Matching_Switch_Case_CS7()
        {
            string path = @".";
            Stream s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);

            // As of CS7, switch no longer limited to just literal values
            switch (s)
            {
                // note 'when', BOTH must be true (a FS, and it must be 'CanWrite' in this test)
                case FileStream w when s.CanWrite: 
                    Console.WriteLine("writable...");
                    break;
                case FileStream r:
                    Console.WriteLine("read-only...");
                    break;
                case MemoryStream ms:
                    Console.WriteLine("streaming to memory...");
                    break;
                default:
                    break;
                case null:
                    Console.WriteLine("null stream...");
                    break;
            }
        }

        private static void Switch_Case()
        {
            var rndNumber = (new Random()).Next(1,5);
            Console.WriteLine($"{rndNumber}");
            switch (rndNumber)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Four or Five");
                    break;
                default:
                    Console.WriteLine("Default...");
                    break;
            }
        }

        private static void Patten_Matching_If_Statement_CS7()
        {
            object obj = "3";
            int j = 4;

            if (obj is int i) // i appears to be a placeholder
            {
                Console.WriteLine($"{i} * {j} = {i * j}");
            }
            else
            {
                Console.WriteLine($"{obj} is not an int.");
            }
        }

        private static void Unary_Binary_Ternary()
        {
            int a = 3;
            int b = 2;
            
            // Binary (two operands)
            int c = a + b;

            // Unary (postfix example)
            a = 3;
            int x = a++;
            Console.WriteLine($"a++ - execution occurs AFTER assignment, resulting in x = {x}");

            // Unary (prefix example)
            a = 3;
            int y = ++a;
            Console.WriteLine($"++a - assignment occurs BEFORE execution, resulting in y = {y}");

            // Ternary
            a = 3;
            bool z = a > 5 ? true : false;
            Console.WriteLine($"Is {a} > 5 = {z}");
        }

        private static void Null_Coalescing_Operator()
        {
            int? canBeNullable = null;

            // return 5 if null
            var result = canBeNullable ?? 5;

            Console.WriteLine(result);
        }

        private static void Nullable_Type()
        {
            int neverNullable = 1;
            int? canBeNullable = null;

            Console.WriteLine($"{canBeNullable}");
        }

        private static void Type_Defaults()
        {
            Console.WriteLine($"{default(int)}");
            Console.WriteLine($"{default(bool)}");
            Console.WriteLine($"{default(DateTime)}");
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

        private static void NameOf_CS6()
        {
            double myDouble = 1.618;
            Console.WriteLine($"{nameof(myDouble)}");
        }
    }
}
