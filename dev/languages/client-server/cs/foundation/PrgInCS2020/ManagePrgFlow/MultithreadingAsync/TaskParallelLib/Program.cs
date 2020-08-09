using System;
using System.Linq;
using System.Threading.Tasks;

namespace TaskParallelLib
{
    class Program
    {
        static readonly Person[] people = Person.GetPeople();

        static void Main(string[] args)
        {
            // Parallel_Invoke();
            // Parallel_ForEach();
            // Parallel_For();
            // Managing_Parallel_For_And_ForEach();
            // Parallel_LINQ();
            // Parallel_LINQ_Attempt_To_Force_Parallelism();
            // Parallel_LINQ_AsOrdered();
            Parallel_LINQ_AsSequential();

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        static void Parallel_Invoke()
        {
            // Parallel.Invoke() accepts Action delegates
            // and creates a task for each of them.

            // Action delegates accepts no parameters, 
            // and do not return a result.

            // Also, the Action delegates can be replaced
            // with lambda expressions, as shown below

            // Note, can cannot control/run a task on a  
            // particular core, the OS determines this
            Parallel.Invoke(() => Work.Task1(),
                            () => Work.Task2(),
                            () => Work.Task3(),
                            () => Work.Task4(),
                            () => Work.Task5(),
                            () => Work.Task6(),
                            () => Work.Task7(),
                            () => Work.Task8(),
                            () => Work.Task9(),
                            () => Work.Task10());
        }

        static void Parallel_ForEach()
        {
            var items = Enumerable.Range(0, 200);

            // Parallel.ForEach accepts: 
            //  1. an IEnumerable collection
            //  2. and some action to perform
            Parallel.ForEach(items, item =>
            {
                Work.WorkOnItem(item);
            });
        }

        static void Parallel_For()
        {
            var items = Enumerable.Range(0, 100).ToArray();

            Parallel.For(0, items.Length, i =>
            {
                Work.WorkOnItem(items[i]);
            });
        }

        static void Managing_Parallel_For_And_ForEach()
        {
            // Manage Parallel.For and Parallel.ForEach with 
            // the ParallelLoopResult return type 
            // and the ParallelLoopState parameter

            // NOTE: You are unable to guarantee the loop will actually
            // stop at a specific iteration

            var items = Enumerable.Range(0, 20).ToArray();

            ParallelLoopResult result =
                Parallel.For(0, items.Count(), (int i, ParallelLoopState loopState) =>
            {
                if (i == 15)
                {
                    loopState.Stop();
                }

                Work.WorkOnItem(items[i]);
            });

            Console.WriteLine($"Completed: {result.IsCompleted}");
            Console.WriteLine($"Items: {result.LowestBreakIteration}");
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
            // AsOrdered() organizes the results to match the order of the input
            // NOTE: There may be a performance hit for this reordering
            
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
            // AsSequential() is used to ensure a particular sequence is followed

            var result = (from person in people.AsParallel()
                          where person.City == "New York"
                          orderby (person.Name)
                          select new
                          {
                              Name = person.Name
                          }).AsSequential().Take(3); // Take only 3 from the results

            foreach (var person in result)
            {
                Console.WriteLine(person.Name);
            }
        }

        static void Parallel_LINQ_ForAll()
        { 
        
        }
    }
}
