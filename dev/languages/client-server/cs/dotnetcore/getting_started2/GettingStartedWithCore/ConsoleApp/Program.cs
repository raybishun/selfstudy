using Microsoft.Extensions.Configuration;
using System;

namespace ConsoleApp
{
    class Program
    {
        public static IConfiguration Configuration;

        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();

            Console.WriteLine("Hello World!");

            string connectionString = Configuration.GetConnectionString("Default");
            Console.WriteLine($"ConnectionStrings value: {connectionString}");

            string otherInfo = Configuration.GetSection("OtherInfo").Value;
            Console.WriteLine($"OtherInfo value: {otherInfo}");

            string demo1 = Configuration.GetSection("Demos").GetSection("Demo1").Value;
            Console.WriteLine($"Demo1 value: {demo1}");
        }
    }
}
