using System;

namespace CollectionsIEnumerableIEnumerator
{
    class Program
    {
        static int[] myArray = new int[] { 1, 2, 3 };

        static void Main(string[] args)
        {
            // BasicArrayExample();
            // TheArrayGetEnumerator();
            InfiniteEnumerable();
        }

        static void BasicArrayExample()
        {
            // An array implements IEnumerable
            // And foreach traverses IEnumerables

            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }
        }

        private static void TheArrayGetEnumerator()
        {
            // Same as the above foreach example
            var enumerator = myArray.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        private static void InfiniteEnumerable()
        {
            //var infiniteEnumerable = new MyInfiniteIEnumerable();
            //foreach (var item in infiniteEnumerable)
            //{
            //    Console.Write($"{item} ");
            //}

            var infiniteEnumerable = new MyInfiniteIEnumerable();
            var enumerator = infiniteEnumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Write($"{enumerator.Current} ");
            }
        }
    }
}
