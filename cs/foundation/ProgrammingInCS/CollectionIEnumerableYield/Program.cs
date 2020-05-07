using System;
using System.Collections;

namespace CollectionIEnumerableYield
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in GetNumbers(0, 10))
            {
                if (i == 3)
                {
                    break;
                }

                Console.WriteLine(i);
            }
        }

        static IEnumerable GetNumbers(int start, int end)
        {
            for (; start <= end; start++)
            {
                yield return start;
            }
        }
    }
}
