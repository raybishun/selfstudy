using System;
using System.Threading.Tasks;

namespace AdalConsoleAppPrototypes
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(await Token.GetToken());
        }
    }
}
