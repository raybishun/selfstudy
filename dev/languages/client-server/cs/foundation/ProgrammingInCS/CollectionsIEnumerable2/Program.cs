using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsIEnumerable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Basket basket = new Basket(
                new string[] { "Apple", "Bananas", "Blueberry" });

            foreach (string fruit in basket)
            {
                Console.WriteLine(fruit);
            }
        }
    }

    class Basket : IEnumerable<string>
    {
        readonly List<string> items;

        public Basket(string[] array)
        {
            items = new List<string>(array);
        }

        public IEnumerator<string> GetEnumerator()
        {
            Console.WriteLine("waiting for a foreach to implicitly call me...");
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}
