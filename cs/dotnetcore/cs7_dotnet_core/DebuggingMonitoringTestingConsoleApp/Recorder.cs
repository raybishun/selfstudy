using System;
using System.Diagnostics;

namespace DebuggingMonitoringTestingConsoleApp
{
    class Recorder
    {
        static Stopwatch timer = new Stopwatch();
        static long bytesPhysicalBefore = 0;
        static long bytesVirtualBefore = 0;

        public static void Start()
        {
            // Force an immediate GC on all generations
            GC.Collect();

            // Suspend the current thread 
            // until the thread that is processing the queue of finalizers 
            // has emptied that queue
            // NOTE: DO NOT USE IN PRODUCTION CODE !!!
            GC.WaitForPendingFinalizers();

            // Force an immediate GC on all generations, again (essentially flushing out GC)
            GC.Collect();

            // Gets the amount of physical memory, in bytes, allocated for the associated process
            bytesPhysicalBefore = Process.GetCurrentProcess().WorkingSet64;

            // Gets the amount of virtual memory, in bytes, allocated for the associated process
            bytesVirtualBefore = Process.GetCurrentProcess().VirtualMemorySize64;

            // Reset time to 0 and start the stopwatch
            timer.Restart();
        }

        public static void Stop()
        {
            timer.Stop();
            long bytesPhysicalAfter = Process.GetCurrentProcess().WorkingSet64;
            long bytesVirtualAfter = Process.GetCurrentProcess().VirtualMemorySize64;

            Console.WriteLine("\tStopped recording.");
            Console.WriteLine($"\t{bytesPhysicalAfter - bytesPhysicalBefore:N0} physical bytes used.");
            Console.WriteLine($"\t{bytesVirtualAfter - bytesVirtualBefore:N0} virtual bytes used.");

            // The Elapsed property returns a TimeSpan (the total timespan elapsed in hours:minutes:seconds)
            Console.WriteLine($"\t{timer.Elapsed} total timespan elapsed.");

            // The ElapsedMilliseconds property returns a long (the total timespan elapsed in ms) 
            Console.WriteLine($"\t{timer.ElapsedMilliseconds:N0} total milliseconds elapsed.");
        }
    }
}
