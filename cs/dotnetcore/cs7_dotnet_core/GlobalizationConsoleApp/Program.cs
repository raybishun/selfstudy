using System;
using System.Globalization;

namespace GlobalizationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo globalization = CultureInfo.CurrentCulture;
            CultureInfo localization = CultureInfo.CurrentUICulture;
            Console.WriteLine(globalization.Name);
            Console.WriteLine(localization.Name);

            Console.ReadLine();  
        }
    }
}
