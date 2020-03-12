using System;

namespace _002_classes_structures_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Value_Type_Enum_Types();

            Console.ReadKey();
        }

        static void Access_Modifiers()
        {
            // Public
            // Private
            // Protected
            // Internal
            // Protected internal
            // Private protected
        }

        static void Data_Types()
        {
            // Value Type - stack
            // Reference Type - heap
        }

        static void Value_Types_Primitive_Types()
        {
            // decimal
            // double
            // float
            // long
            // int
            // short
            // char
            // boolean
            // byte
            // Enumerators
        }

        // enum My_Days_Default_0 { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        // enum My_Days_Default_Change_1 { Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat };
        enum My_Days_as_Short : short { Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat };

        static void Value_Type_Enum_Types()
        {
            foreach (My_Days_as_Short day in Enum.GetValues(typeof(My_Days_as_Short)))
            {
                Console.WriteLine($"{(int)day}. {day}");
            }
        }

        static void Struct_Types()
        {

        }
    }
}
