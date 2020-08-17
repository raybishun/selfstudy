using System;
using System.Threading;

namespace TPL_Parallel_Basics
{
    class TPL_Work
    {
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
        public static void Task3()
        {
            Console.WriteLine("Task-3 starting...");
            Thread.Sleep(2000);
            Console.WriteLine("Task-3 end.");
        }

        public static void Task4()
        {
            Console.WriteLine("Task-4 starting...");
            Thread.Sleep(1000);
            Console.WriteLine("Task-4 end.");
        }
        public static void Task5()
        {
            Console.WriteLine("Task-5 starting...");
            Thread.Sleep(2000);
            Console.WriteLine("Task-5 end.");
        }

        public static void Task6()
        {
            Console.WriteLine("Task-6 starting...");
            Thread.Sleep(1000);
            Console.WriteLine("Task-6 end.");
        }
        public static void Task7()
        {
            Console.WriteLine("Task-7 starting...");
            Thread.Sleep(2000);
            Console.WriteLine("Task-7end.");
        }

        public static void Task8()
        {
            Console.WriteLine("Task-8 starting...");
            Thread.Sleep(1000);
            Console.WriteLine("Task-8end.");
        }

        public static void Task9()
        {
            Console.WriteLine("Task-9 starting...");
            Thread.Sleep(2000);
            Console.WriteLine("Task-9 end.");
        }

        public static void Task10()
        {
            Console.WriteLine("Task-10 starting...");
            Thread.Sleep(1000);
            Console.WriteLine("Task-10 end.");
        }

        // 
        public static void WorkOnItem(object item)
        {
            Console.WriteLine($"Started working on: {item}");
            Thread.Sleep(1000);
            Console.WriteLine($"Finished working on: {item}");
        }
    }
}
