using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace manageappsecretsconsoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\raybi\AppData\Roaming\Microsoft\UserSecrets\37212dca-3648-4db5-93e3-2cd908d7e7af\secrets.json";

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(path, true, true)
                .Build();

            Console.WriteLine($"{config["ConnectionString"]}");
        }
    }
}
