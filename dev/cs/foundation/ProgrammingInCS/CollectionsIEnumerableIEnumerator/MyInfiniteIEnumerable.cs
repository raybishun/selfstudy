using System.Collections;
using System.Collections.Generic;

namespace CollectionsIEnumerableIEnumerator
{
    class MyInfiniteIEnumerable : IEnumerable<int>
    {
        // Typically GetEnumerator() is used to 
        // return some data/payload to the caller
        private int[] someData = new[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

        public IEnumerator GetEnumerator()
        {
            return new MyInfiniteIEnumerator(someData);
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return new MyInfiniteIEnumerator(someData);
        }
    }
}
