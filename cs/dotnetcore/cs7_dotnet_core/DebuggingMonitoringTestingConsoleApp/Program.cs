using System;
using System.Linq;

namespace DebuggingMonitoringTestingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitoring_Stopwatch();

            Console.ReadLine();
        }

        private static void Monitoring_Stopwatch()
        {
            Console.WriteLine("Press ENTER to start timer: ");
            Console.ReadLine();

            Recorder.Start();

            int[] largeArrayOfInts = Enumerable.Range(1, 10000).ToArray();

            Console.WriteLine("Press ENTER to stop timer: ");
            Console.ReadLine();

            Recorder.Stop();
        }
    }
}
