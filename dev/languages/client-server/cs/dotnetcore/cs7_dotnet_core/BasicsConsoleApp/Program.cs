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
            // Explicit_Casting();
            // Convert_Type();
            // Rounding_Rules();
            // Parse_With_Parsing();
            // Parse_With_TryParse();
            // Specific_Exceptions();
            // Using_Dispose();
            // Automatic_Dispose();
            // Silent_Overflow();
            // Check_For_Overflow();
            Unchecked_Overflow();

            Console.ReadKey();
        }

        private static void Unchecked_Overflow()
        {
            // Default (compile-time) behavior
            // VS will tell you that 'The operation overflows at compile time in checked mode'
            // As such, will not permit you to compile
            
            //int y = int.MaxValue + 1;

            // To turn this 'checked mode' off
            // Although, don't know why you would ever do this...
            unchecked
            {
                int y = int.MaxValue + 1;
                Console.WriteLine(y);
            }
        }

        private static void Check_For_Overflow()
        {
            checked
            {
                try
                {
                    int x = int.MaxValue;
                    Console.WriteLine(x);
                    x++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void Silent_Overflow()
        {
            // Checked tells .NET to throw an exception when an 
            // overflow occurs, instead of permitting it to occur

            // The below shows when the max value is reached,
            // it overflows to its minimum value, and starts
            // incrementing from there
            try
            {
                int x = int.MaxValue;
                Console.WriteLine(x);
                x++;
                Console.WriteLine(x);
                x++;
                Console.WriteLine(x);
                x++;
                Console.WriteLine(x);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Automatic_Dispose()
        {
            string path = @"c:\temp";

            using (FileStream file = File.OpenWrite(Path.Combine(path, "file.txt")))
            {
                using (StreamWriter sw = new StreamWriter(file))
                {
                    try
                    {
                        sw.WriteLine("Using will call Dispose if object not null...");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{ex.GetType()} -> {ex.Message}");
                    }
                }
            }
        }

        private static void Using_Dispose()
        {
            string path = @"c:\temp";
            FileStream file = null;
            StreamWriter sw = null;

            try
            {
                if (Directory.Exists(path))
                {
                    file = File.OpenWrite(Path.Combine(path, "test_file.txt"));
                    sw = new StreamWriter(file);
                    sw.WriteLine("Hello from .NET Core");
                }
                {
                    Console.WriteLine($"{path} does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} -> {ex.Message}");
            }
            finally
            {
                sw.Dispose();

                if (file != null)
                {
                    file.Dispose();
                }
            }
        }

        private static void Specific_Exceptions()
        {
            Console.Write("Enter age: ");

            try
            {
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine($"{age + 1}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverflowException");
            }
            catch (StackOverflowException)
            {
                Console.WriteLine("Don't believe you are able to catch a StackOverflowException...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Parse_With_TryParse()
        {
            Console.Write("Enter age: ");

            int result; // assigned if tryparse was successful

            string input = Console.ReadLine();

            bool isInt = int.TryParse(input, out result);

            if (isInt)
            {
                Console.WriteLine($"{Convert.ToInt32(input) + 1}");
            }
            else
            {
                Console.WriteLine($"{input} NaN.");
            }

            // Or all in one line
            int value = int.TryParse(input, out result) ? Convert.ToInt32(input) + 1 : result;

            Console.WriteLine(value);
        }

        private static void Parse_With_Parsing()
        {
            Console.Write("Enter age: ");

            try
            {
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine($"{age + 1}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.GetType()} -> {ex.Message}"); ;
            }
        }

        private static void Rounding_Rules()
        {
            // NOTE: In school we learned to round up if greater than .5, and down if less than .5
            // HOWEVER, in C#, 'Banker's Rounding' is applied, where 
            // round up if .5 or higher AND the whole number is ODD, and round down if the whole number is EVEN
            // And always round down when less than .5

            // NOTE: JavaScript uses the traditional method taught in school

            double i = 9.49;
            double j = 9.5;
            double k = 10.49;
            double l = 10.5;
            Console.WriteLine($"{i} \t {Convert.ToInt32(i)}");
            Console.WriteLine($"{j} \t {Convert.ToInt32(j)}");
            Console.WriteLine($"{k} \t {Convert.ToInt32(k)}");
            Console.WriteLine($"{l} \t {Convert.ToInt32(l)}");
        }

        private static void Convert_Type()
        {
            // A key difference between casting using ( ) is that
            // converting rounds the value up or down, rather than 
            // simply the trimming the decimal off
            double g = 9.8;
            int h = Convert.ToInt32(g);
            Console.WriteLine($"{g} | {h}");
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
