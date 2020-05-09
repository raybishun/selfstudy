using System.Collections;
using System.Collections.Generic;

namespace CollectionsIEnumerableIEnumerator
{
    class MyInfiniteIEnumerable : IEnumerable<int>
    {
        public IEnumerator GetEnumerator()
        {
            return new MyInfiniteIEnumerator();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return new MyInfiniteIEnumerator();
        }
    }
}
