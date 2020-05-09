using System.Collections;
using System.Collections.Generic;

namespace CollectionsIEnumerableIEnumerator
{
    class MyInfiniteIEnumerator : IEnumerator<int>
    {
        private int[] mValues;

        private int mIndex = -1;

        // public int Current { get; private set; } = 0;
        public int Current => mValues[mIndex];

        object IEnumerator.Current => Current;

        public MyInfiniteIEnumerator(int[] values)
        {
            mValues = values;
        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            //Current++;
            mIndex++;

            // Infinity
            // return true;

            return mIndex < mValues.Length;
        }

        public void Reset()
        {
            // Current = 0;
            mIndex = 0;
        }
    }
}
