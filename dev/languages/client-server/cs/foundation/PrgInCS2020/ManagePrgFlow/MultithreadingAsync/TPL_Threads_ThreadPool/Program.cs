using System;
using System.Threading;

namespace TPL_Threads_ThreadPool
{
    class Program
    {
        // Threads are a lower level of abstraction than tasks
        // A task is a unit of work to be executed
        // A thread is runs a process on the OS

        // *** By default, threads are created as foreground processes *** //
        // *** Conversely, tasks are created as background processes *** //

        // An application cannot terminate while it's foreground thread is running

        // Threads have a priority, tasks do not

        // Threads are unable to pass results to one another (they use shared variables),
        // which means they can be prone to synchronization issues

        // Threads do not have the concept of 'continuation' as tasks do,
        // however, threads have a join method, where they can pause for another
        // threat to complete it's work

        // Threads to not support exception aggregation (tasks do)

        static void Main(string[] args)
        {
            // Basic_Thread();
            ThreadStart_Delegate();


            Console.WriteLine("Done");
            Console.ReadKey();
        }

        static void Basic_Thread()
        {
            Thread t = new Thread(Work.SomeWork);
            t.Start();
        }

        static void ThreadStart_Delegate()
        {
            // The ThreadStart Delegate is legacy, and no longer required
            ThreadStart ts = new ThreadStart(Work.SomeWork);
            Thread t = new Thread(ts);
            t.Start();
        }
    }
}
