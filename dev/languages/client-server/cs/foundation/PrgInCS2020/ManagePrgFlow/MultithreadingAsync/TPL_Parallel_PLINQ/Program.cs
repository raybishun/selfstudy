using System;
using System.Linq;

namespace TPL_Parallel_PLINQ
{
    class Program
    {
        static readonly Person[] people = Person.GetPeople();

        static void Main(string[] args)
        {
            // Parallel_LINQ();
            // Parallel_LINQ_Attempt_To_Force_Parallelism();
            // Parallel_LINQ_AsOrdered();
            // Parallel_LINQ_AsSequential();
            // Parallel_LINQ_ForAll();
            PLINQ_Exceptions();

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        static void Parallel_LINQ()
        {
            // NOTE: Proceed with caution - AsParallel() will determine 
            // whether the LINQ statement can be run in parallel or not
            var result = from person in people.AsParallel()
                         where person.City == "New York"
                         select person;

            foreach (var person in result)
            {
                Console.WriteLine(person.Name);
            }
        }

        static void Parallel_LINQ_Attempt_To_Force_Parallelism()
        {
            // Forcing Parallelism 
            var result = from person in people.AsParallel()
                          // Request the query not run on more than 4 cores
                          .WithDegreeOfParallelism(4)
                          .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                         where person.City == "New York"
                         select person;

            foreach (var person in result)
            {
                Console.WriteLine(person.Name);
            }
        }

        static void Parallel_LINQ_AsOrdered()
        {
            // AsOrdered() 
            // - Organizes the results to match the order of the input
            // - There may be a performance hit for this reordering

            var result = from person in people.AsParallel()
                         .AsOrdered()
                         where person.City == "New York"
                         select person;

            foreach (var person in result)
            {
                Console.WriteLine(person.Name);
            }
        }

        static void Parallel_LINQ_AsSequential()
        {
            // AsSequential() 
            // - Used to ensure a particular sequence is followed

            var result = (from person in people.AsParallel()
                          where person.City == "New York"
                          orderby (person.Name)
                          select new
                          {
                              Name = person.Name
                          }).AsSequential().Take(3); // NOTE: Only take 3 from the results

            foreach (var person in result)
            {
                Console.WriteLine(person.Name);
            }
        }

        static void Parallel_LINQ_ForAll()
        {
            // ForAll()
            // - Is the parallel version of a normal ForEach
            // - Interestingly enough, execution begins before the query has actually completed
            // - Also, due to parallel processing, the output will not match the order of the input

            var result = from person in people.AsParallel()
                         where person.City == "New York"
                         select person;

            result.ForAll(person => Console.WriteLine(person.Name));
        }

        static void PLINQ_Exceptions()
        {
            try
            {
                var result = from person in people.AsParallel()
                             where FilterCity(person.City)
                             select person;

                result.ForAll(person => Console.WriteLine(person.Name));
            }
            catch (AggregateException e)
            {
                Console.WriteLine($"{e.InnerExceptions.Count}: exceptions.");
            }
        }

        static bool FilterCity(string city)
        {
            if (city == "")
            {
                throw new ArgumentException(city);
            }

            // Filter on New York
            return city == "New York";
        }
    }
}
