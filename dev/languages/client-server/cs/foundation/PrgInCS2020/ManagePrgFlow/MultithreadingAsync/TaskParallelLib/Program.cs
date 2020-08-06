using System;
using System.Threading.Tasks;

namespace TaskParallelLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(() => Parallel_Invoke.Task1(),
                            () => Parallel_Invoke.Task2());

            Console.WriteLine("Done.");
            Console.ReadKey();
        }
    }
}
