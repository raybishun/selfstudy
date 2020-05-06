using System;
using System.Linq;

namespace LINQFilteringOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeIdToRemove = 21;

            int[] employeeIds = GetIds();

            int[] filteredEmployeeIds = employeeIds
                .Distinct()                 // remove duplicates
                .Where(value => value != employeeIdToRemove)
                .OrderByDescending(x => x)  // sort from highest to lowest
                .ToArray();

            foreach (var id in filteredEmployeeIds)
            {
                Console.Write($"{id} ");
            }
        }

        private static int[] GetIds()
        {
            int[] ids = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            return ids;
        }
    }
}
