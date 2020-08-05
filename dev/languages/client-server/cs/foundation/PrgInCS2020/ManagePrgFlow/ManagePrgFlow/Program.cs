using System;
using System.Threading;

namespace ManagePrgFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void Task1()
        {
            Console.WriteLine("Task 1 starting...");
            Thread.Sleep(2000);
            Console.WriteLine("Task 1 ending.");
        }
    }
}
