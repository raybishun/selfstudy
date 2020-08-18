using System;
using System.Threading;

namespace Threads_Passing_Data
{
    class Program
    {
        static void DoWork(object data)
        {
            Console.WriteLine($"Working on: {data}");
            Thread.Sleep(1000);
        }
        
        static void Main(string[] args)
        {
            // Series: Managing Program Flow
            // Section: Implement multithreading and asynchronous processing
            // Sub-Section: Threads and ThreadPool
            // ===========================================================

            // Topic: Passing data into a thread
            // -----------------------------------------------------------

            // Pass data into a thread using the ParameterizedThreadStart
            // delegate which accepts an object as a parameter
            // Note: The data passed into a thread is always an object
            ParameterizedThreadStart pts = 
                new ParameterizedThreadStart(DoWork);
            Thread t = new Thread(pts);
            t.Start(2020);

            // Pass data into a thread using a lambda expression
            // that accepts a parameter
            Thread t2 = new Thread((data) => 
            {
                DoWork(data);
            });
            t2.Start(2021);
        }
    }
}
