using System;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {
        static string[] faanam = { "FaceBook", "Amazon", "Apple", "Netflix", "Alphabet", "Microsoft" };

        static void Main(string[] args)
        {
            Console.WriteLine(Search1(faanam, "Microsoft"));
            Console.WriteLine(Search2(faanam, "Microsoft"));
        }

        static string Search1(string[] array, string element)
        {
            return array.Where(item => item.Equals(element.Trim())).FirstOrDefault();
        }

        static string Search2(string[] array, string element)
        {
            var query = from item in array
                        where item.Equals(element.Trim())
                        select item;

            return query.FirstOrDefault();
        }
    }
}
