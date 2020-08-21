using System;
using System.Threading;

namespace Threads_Local
{
    class Program
    {
        static void Main(string[] args)
        {
            // Series: Managing Program Flow
            // Section: Implement multithreading and asynchronous processing
            // Sub-Section: Threads and ThreadPool
            // ===========================================================

            // Topic: The ThreadLocal Class
            // The ThreadLocal class provides thread-local storage of data
            // -----------------------------------------------------------

        }

        static ThreadLocal<Random> RandomGenerator = new ThreadLocal<Random>(() =>
        {
            return new Random(2);
        });
    }
}
