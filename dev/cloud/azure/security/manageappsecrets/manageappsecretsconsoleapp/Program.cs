using Microsoft.Extensions.Configuration;
using System;

namespace manageappsecretsconsoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(@"C:\Users\raybi\AppData\Roaming\Microsoft\UserSecrets\37212dca-3648-4db5-93e3-2cd908d7e7af\secrets.json", true, true)
                .Build();

            Console.WriteLine($"{config["ConnectionString"]}");
        }
    }
}
