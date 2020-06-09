using System;
using System.Linq;
using System.Text;

namespace DebuggingMonitoringTestingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Monitoring_Large_Int_Array();
            Monitoring_StringBuilder();

            Console.ReadLine();
        }

        private static void Monitoring_StringBuilder()
        {
            int[] numbers = Enumerable.Range(1, 100000).ToArray();

            // ----------------------------------------------------------------
            // Test using String Class
            // ----------------------------------------------------------------
            Recorder.Start();
            Console.WriteLine("Test using String Class");
            string s = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                s += numbers[i] + ", ";
            }
            Recorder.Stop();
            Console.WriteLine("");

            // ----------------------------------------------------------------
            // Test using StringBuilder Class
            // ----------------------------------------------------------------
            Recorder.Start();
            Console.WriteLine("Test using StringBuilder Class");
            var sb = new StringBuilder();
            for (int i = 0; i < numbers.Length; i++)
            {
                sb.Append(numbers[i]);
                sb.Append(", ");
            }
            Recorder.Stop();
        }

        private static void Monitoring_Large_Int_Array()
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
