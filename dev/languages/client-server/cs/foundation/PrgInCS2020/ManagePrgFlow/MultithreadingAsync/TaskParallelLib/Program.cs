using System;
using System.Threading.Tasks;

namespace TaskParallelLib
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Task.Parallel class in the TPL (Task Parallel Library),
            // provides 3 methods that can be used to execute tasks in parallel

            Tasks_Parallel_Invoke();


            Console.ReadKey();
        }

        static void Tasks_Parallel_Invoke()
        {
            // Parallel.Invoke() accepts Action delegates
            // and creates a task for each of them.

            // Action delegates accepts no parameters, 
            // and do not return a result.

            // Also, the Action delegates can be replaced
            // with lambda expressions, as shown below

            // Note, can cannot control/run a task on a  
            // particular core, the OS determines this
            Parallel.Invoke(() => BunchOfTasks.Task1(),
                            () => BunchOfTasks.Task2(),
                            () => BunchOfTasks.Task3(),
                            () => BunchOfTasks.Task4(),
                            () => BunchOfTasks.Task5(),
                            () => BunchOfTasks.Task6(),
                            () => BunchOfTasks.Task7(),
                            () => BunchOfTasks.Task8(),
                            () => BunchOfTasks.Task9(),
                            () => BunchOfTasks.Task10());

            Console.WriteLine("Done.");
        }

    }
}
