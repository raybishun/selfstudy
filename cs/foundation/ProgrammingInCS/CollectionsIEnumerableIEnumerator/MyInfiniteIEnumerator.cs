using System.Collections;
using System.Collections.Generic;

namespace CollectionsIEnumerableIEnumerator
{
    class MyInfiniteIEnumerator : IEnumerator<int>
    {
        public int Current { get; private set; } = 0;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            Current++;

            // Infinity
            return true;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
