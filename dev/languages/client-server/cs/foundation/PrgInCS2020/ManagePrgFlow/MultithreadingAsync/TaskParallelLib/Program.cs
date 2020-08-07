using System;
using System.Linq;
using System.Threading.Tasks;

namespace TaskParallelLib
{
    class Program
    {
        static void Main(string[] args)
        {
            // Withing the System.Threading.Tasks namespace, 
            // aka TPL (Task Parallel Library), the Parallel class 
            // provides 3 methods that can be used to execute tasks in parallel

            // Parallel_Invoke();
            // Parallel_ForEach();
            Parallel_For();

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
    }
}
