using System;
using System.Collections.Generic;

namespace CollectionsQueue
{
    class Program
    {
        #region TODO
        // SortedList
        // LinkedList<T>
        // HashTable
        // Array<T> ??
        #endregion

        static void Main(string[] args)
        {
            // Used to store a collection of ordered objects
            // Is strongly typed
            // uses FIFO
            // Uses zero-based indices

            Queue<string> days = new Queue<string>();
            days.Enqueue("Sun");
            days.Enqueue("Mon");
            days.Enqueue("Tue");
            days.Enqueue("Wed");
            days.Enqueue("Thu");
            days.Enqueue("Fri");
            days.Enqueue("Sat");

            foreach (string day in days)
            {
                Console.Write($"{day} ");
            }

            string[] daysOfWeek = days.ToArray();
            Console.WriteLine($"\n{daysOfWeek[0]}");

            // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?redirectedfrom=MSDN&view=netcore-3.1
        }
    }
}
