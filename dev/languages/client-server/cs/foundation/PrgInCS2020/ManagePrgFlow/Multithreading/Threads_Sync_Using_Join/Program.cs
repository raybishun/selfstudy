using System;
using System.Threading;

namespace Threads_Sync_Using_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            // Series: Managing Program Flow
            // Section: Implement multithreading and asynchronous processing
            // Sub-Section: Threads and ThreadPool
            // ===========================================================

            // Topic: Thread synchronization using Join
            // Threads can be joined using the Join() method.
            // -----------------------------------------------------------
            JoiningThreads();
        }

        static void JoiningThreads()
        {
            Thread t = new Thread(() => 
            {
                Console.WriteLine("Background thread starting...");
                Thread.Sleep(2000);
                Console.WriteLine("Background thread completed.");
            });

            t.Start();
            Console.WriteLine("Foreground thread will be joined...");
            t.Join();
            Console.WriteLine("Foreground thread will now exit.");
        }
    }
}
