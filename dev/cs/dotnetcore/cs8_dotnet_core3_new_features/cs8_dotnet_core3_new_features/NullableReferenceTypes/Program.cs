using System;

namespace NullableReferenceTypes
{
    class Program
    { static void Main(string[] args)
        {
            var student = new Student() { FirstName = "Ray" };

            Console.WriteLine($"{student.LastName.ToUpper()}, {student.FirstName.ToUpper()}");
        }
    }
}
