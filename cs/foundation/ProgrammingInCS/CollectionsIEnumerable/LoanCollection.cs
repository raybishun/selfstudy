using System.Collections;

namespace CollectionsIEnumerable
{
    class LoanCollection : IEnumerable
    {
        private readonly Loan[] collectionOfLoans;

        public LoanCollection(Loan[] loans)
        {
            collectionOfLoans = new Loan[loans.Length];

            for (int i = 0; i < loans.Length; i++)
            {
                collectionOfLoans[i] = loans[i];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return collectionOfLoans.GetEnumerator();
        }
    }
}
