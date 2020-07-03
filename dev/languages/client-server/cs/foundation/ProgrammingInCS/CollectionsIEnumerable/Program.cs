using System;
using System.Collections.Generic;

namespace CollectionsIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Loan> personalLoans = new List<Loan>()
            { 
                new Loan {FullName = "Peter Parker", LoanAmount = 50000M, Terms = 15},
                new Loan {FullName = "Bruce Wayne", LoanAmount =  95000M, Terms = 10},
                new Loan {FullName = "Bruce Banner", LoanAmount = 10000M, Terms = 30}
            };

            LoanCollection loanCollection = new LoanCollection(personalLoans.ToArray());

            //foreach (var loan in loanCollection)
            //{
            //    Console.WriteLine(loan.ToString());
            //}

            var item = loanCollection.GetEnumerator();

            if (item.MoveNext())
            {
                Console.WriteLine(item.Current);
            }
        }
    }
}
