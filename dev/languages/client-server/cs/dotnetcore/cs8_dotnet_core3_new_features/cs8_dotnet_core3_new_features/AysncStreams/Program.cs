using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AysncStreams
{
    class Program
    {
        async static Task Main(string[] args)
        {
            await foreach (var student in GetStudentsAsync())
            {
                Console.WriteLine($"{student.FirstName}");
            }        
        }

        async static IAsyncEnumerable<Student> GetStudentsAsync()
        {
            var list = new List<Student>()
            {
                new Student() { FirstName = "Peter", LastName = "Parker", Email = "peter.parker@gmail.com", Gpa = 3.9},
                new Student() { FirstName = "Bruce", LastName = "Wayne", Email = "bruce.wayne@gmail.com", Gpa = 4.1},
                new Student() { FirstName = "Clark", LastName = "Kent", Email = "clark.kent@gmail.com", Gpa = 4.0}
            };

            foreach (var student in list)
            {
                await Task.Delay(2000);

                // yield returns something asynchronously
                // In this case, yield, will return student as an asynchronous stream
                yield return student;
            }
        }
    }
}
