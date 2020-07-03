using System;

namespace LogicalConditionalNullOperators
{
    class Program
    {
        const int firstValue = 5;
        const int secondValue = 6;
        
        // Note: int? cannot be declared const
        static int? nullValue = null;

        static void Main(string[] args)
        {
            //Logical_OR();
            //Conditional_OR();

            //Logical_AND();
            //Conditional_AND();

            Null_Coalesing();
            Ternary_Operator();
        }

        static void Logical_OR()
        {
            // All tests are evaluated (so use sparingly)
            // Only 1 must be true to return true
            // All must be false to return false
            bool answer = firstValue > 100 | firstValue == 5  | firstValue < 4;
            Console.WriteLine(answer);

            // *** the logical XOR (^ bitwise exclusive OR) behaves similar to 
            // the logical OR operator
        }
        static void Conditional_OR()
        {
            // Returns true if ANY test is true 
            // If 1st test is true, returns true (and does NOT test the other options)
            bool answer = firstValue > 100 || firstValue == 5 || firstValue < 4;
            Console.WriteLine(answer);
        }
        static void Logical_AND()
        {
            // All tests are evaluated (so use sparingly)
            // All must be true to return true
            bool answer = (firstValue > 100 & firstValue == 5);
            Console.WriteLine(answer);
        }

        static void Conditional_AND()
        {
            // All must be true to return true
            // If 1st test is false, returns false (and does NOT test the other options)
            bool answer = (firstValue > 100 && firstValue == 5);
            Console.WriteLine(answer);
        }

        static void Null_Coalesing()
        {
            // If the 1st operand is not null, return its value
            // Otherwise, if the 1st operand is null, return the value of the 2nd operand
            Console.WriteLine(nullValue ?? firstValue);
        }

        static void Ternary_Operator()
        {
            // If true, return 1st option
            // If false, return 2nd option
            Console.WriteLine(firstValue > secondValue ? "Yes" : "No");
        }
    }
}
