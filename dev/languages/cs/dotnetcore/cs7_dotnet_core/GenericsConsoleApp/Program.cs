using System;
using System.Collections.Generic;

namespace GenericsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generics_List();
            Generics_Dictionary();

            Console.ReadLine();
        }

        private static void Generics_Dictionary()
        {
            var faang = new Dictionary<string, double>
            {
                { "FB", 156.79 },
                { "AAPL", 247.74 },
                { "NFLX", 357.12 },
                { "GOOG", 1110.71 }
            };

            foreach (KeyValuePair<string, double> stock in faang)
            {
                Console.WriteLine($"{stock.Key} \t {stock.Value}");
            }
        }

        private static void Generics_List()
        {
            List<string> cities = new List<string>();
            cities.Add("New York");
            cities.Add("Austin");
            cities.Add("London");
            cities.Add("Tokyo");
            cities.Add("Hong Kong");

            cities.Insert(1, "Toronto");

            cities.RemoveAt(2);

            cities.Remove("Hong Kong");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
