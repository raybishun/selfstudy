using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TPL_Tasks
{
    class Work
    {
        public static void SomeWork()
        {
            Console.WriteLine("Stating work...");
            Thread.Sleep(2000);
            Console.WriteLine("Work completed.");
        }

        public static void SomeWork(int i)
        {
            Console.WriteLine($"Task {i} starting...");
            Thread.Sleep(2000);
            Console.WriteLine($"Task {i} completed.");
        }

        public static void HelloTask()
        {
            Thread.Sleep(1000);
            Console.Write("Hello, ");
        }

        public static void WorldTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("World!");
        }

        public static void ExceptionTask()
        {
            Console.WriteLine("Run when exception occurred...");
        }

        public static int CalcResult()
        {
            Console.WriteLine("Stating work...");
            Thread.Sleep(2000);
            Console.WriteLine("Work completed.");
            return 99;
        }

        public static void ChildTask(object state)
        {
            Console.WriteLine($"ChildTask {state} starting...");
            Thread.Sleep(2000);
            Console.WriteLine($"ChildTask {state} completed.");
        }
    }
}
