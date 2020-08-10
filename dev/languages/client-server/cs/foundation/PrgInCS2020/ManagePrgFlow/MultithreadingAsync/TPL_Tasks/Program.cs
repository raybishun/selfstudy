using System;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_Tasks
{
    class Program
    {
        static void SomeWork()
        {
            Console.WriteLine("Stating work...");
            Thread.Sleep(2000);
            Console.WriteLine("Work completed.");

            Console.WriteLine("Done");
            Console.ReadKey();
        }
        
        static void Main(string[] args)
        {
            DoWork();
        }

        static void DoWork()
        {
            Task t = new Task(() => SomeWork());
            t.Start();
            t.Wait();
        }
    }
}
