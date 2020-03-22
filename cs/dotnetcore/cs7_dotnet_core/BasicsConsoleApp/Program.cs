using System;

namespace BasicsConsoleApp
{
    class Program
    {
        // Casting Objects (via boxing andu Unboxing) comes with a performance cost
        // However, 'generics' (introduced in C# 2) is more efficient
        // Reference Types - point to where the value is stored in memory; can have a 'null' literal value
        // Value Types - must have a value (but can also be 'nullable')

        static void Main(string[] args)
        {
            //NameOf_CS6();
            //DigitalSeparators_CS7();
            //DynamicTypes_CS4();
            //Implicity_Typed_Variables();
            //Type_Defaults();
            //Nullable_Type();
            Null_Coalescing_Operator();

            Console.ReadKey();
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

        private static void DigitalSeparators_CS7()
        {
            // Base10
            int decimalNotation = 1_000_000;

            // Leading digital separator requires C# 7.2 
            // Base2
            // int binaryNotation = 0b_1111_0100_0010_0100_0000;

            // Base16
            int hexNotation = 0xF_4240;
        }

        private static void NameOf_CS6()
        {
            double myDouble = 1.618;
            Console.WriteLine($"{nameof(myDouble)}");
        }

    }
}
