using System;
using System.Threading;

namespace Threads_Lambda_Exp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Series: Managing Program Flow
            // Section: Implement multithreading and asynchronous processing
            // Sub-Section: Threads and ThreadPool
            // ===========================================================

            // Topic: Starting a thread using a lambda expression
            // -----------------------------------------------------------

            Thread t = new Thread(() =>
            {
                Console.WriteLine("Hello World!");
                Thread.Sleep(1000);
            });

            // The main thread starts a new background thread
            t.Start();

            // The main thread will also continue and execute the below 
            Console.WriteLine("Done");
        }
    }
}
