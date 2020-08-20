using System;
using System.Threading;

namespace Threads_Abort
{
    class Program
    {
        static int ctr = 1;

        static void Main(string[] args)
        {
            // Series: Managing Program Flow
            // Section: Implement multithreading and asynchronous processing
            // Sub-Section: Threads and ThreadPool
            // ===========================================================

            // Topic: Aborting a thread
            // -----------------------------------------------------------
            // Thread_Abort();
            Gracefully_Abort_Thread();
        }

        static void Thread_Abort()
        {
            try
            {
                // Abruptly terminate a thread 
                // Note: Thread.Abort() does not clean up resources
                Thread t = new Thread(() =>
                {
                    while (true)
                    {
                        Console.WriteLine(ctr);
                        Thread.Sleep(1000);
                        ctr++;
                    }
                });
                t.Start();

                Console.WriteLine("Press any key to abort...");
                Console.ReadKey();
                // Appears Thread.Abort() is not supported in .NET Core
                t.Abort();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Gracefully_Abort_Thread()
        {
            // Simply uses a shared flag variable
            // to gracefully abort and allow for normal cleanup
            bool isRunning = true;

            Thread t = new Thread(() =>
            {
                while (isRunning)
                {
                    Console.WriteLine(ctr);
                    Thread.Sleep(1000);
                    ctr++;
                }
            });
            t.Start();

            Console.WriteLine("Press any key to abort...");
            Console.ReadKey();
            isRunning = false;
        }
    }
}
