using System;

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

        static void Main(string[] args)
        {
            // NameOf_CS6();
            // DynamicTypes_CS4();
            // Implicity_Typed_Variables();
            // Type_Defaults();
            // Nullable_Type();
            // Null_Coalescing_Operator();
            Unary_Binary_Ternary();

            Console.ReadKey();
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
