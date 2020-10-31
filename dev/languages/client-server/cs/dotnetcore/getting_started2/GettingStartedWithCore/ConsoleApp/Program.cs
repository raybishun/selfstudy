using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        public static IConfiguration Configuration;

        static void Main(string[] args)
        {
            // ParsingTheAppSettingsJsonFile();
            WorkingWithTextFileCrossPlatform();
        }

        static void ParsingTheAppSettingsJsonFile()
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

        static void WorkingWithTextFileCrossPlatform()
        {
            // Challenge: 
            // ----------------------------------------------------------------
            // Create a folder. Create a file in that folder.
            // Code must run on Windows and Linux
            // So you need to account for the different slashes

            // ./Logs/LogFile.txt
            
            string path = Path.Combine(".", "Logs");
            string file = Path.Combine(path, "LogFile.txt");

            Directory.CreateDirectory(path);

            List<string> logs = new List<string>
            { 
                "First log entry...",
                "Second log entry...",
                "Third log entry..."
            };

            File.WriteAllLines(file, logs);

            foreach (string log in File.ReadAllLines(file))
            {
                Console.WriteLine(log);
            }
        }
    }
}
