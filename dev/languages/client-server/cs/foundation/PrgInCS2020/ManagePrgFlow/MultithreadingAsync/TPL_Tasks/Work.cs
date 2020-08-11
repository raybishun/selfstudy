using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TPL_Tasks
{
    class Work
    {
        public static void SomeWork()
        {
            Console.WriteLine("Stating work...");
            Thread.Sleep(2000);
            Console.WriteLine("Work completed.");
        }

        public static int CalcResult()
        {
            Console.WriteLine("Stating work...");
            Thread.Sleep(2000);
            Console.WriteLine("Work completed.");
            return 99;
        }
    }
}
