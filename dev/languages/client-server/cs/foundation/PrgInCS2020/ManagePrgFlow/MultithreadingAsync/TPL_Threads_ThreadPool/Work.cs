using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TPL_Threads_ThreadPool
{
    class Work
    {
        public static void SomeWork()
        {
            Console.WriteLine("Hello from thread...");
            Thread.Sleep(2000);
        }

      
    }
}
