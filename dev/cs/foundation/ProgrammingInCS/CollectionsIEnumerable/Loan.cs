namespace CollectionsIEnumerable
{
    class Loan
    {
        public string FullName { get; set; }
        public decimal LoanAmount { get; set; }
        public int Terms { get; set; }

        public override string ToString()
        {
            return $"{FullName}\t{LoanAmount:C}\t{Terms}";
        }
    }
}
