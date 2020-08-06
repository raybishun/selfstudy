using System;
using System.Threading;

namespace TaskParallelLib
{
    class Parallel_Invoke
    {
        // Parallel.Invoke() accepts Action delegates
        // and creates a task for each of them.

        // Action delegates accepts no parameters, 
        // and do not return a result.

        public static void Task1()
        {
            Console.WriteLine("Task-1 starting...");
            Thread.Sleep(2000);
            Console.WriteLine("Task-1 end.");
        }

        public static void Task2()
        {
            Console.WriteLine("Task-2 starting...");
            Thread.Sleep(1000);
            Console.WriteLine("Task-2 end.");
        }
    }
}
