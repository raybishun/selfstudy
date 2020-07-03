using System;

namespace cs_interactive
{
    class Program
    {
        static void Main(string[] args)
        {
            // View\Other Windows\C# Interacive

            // STEPS
            /*
                #r "System.Net.Http"
                using System.Net.Http;
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://www.microsoft.com");
                var response = await client.GetAsync("about");
                response.StatusCode
                Result: OK

                response.Content.Headers.GetValues("Content-Type")
                Result: string[1] { "text/html; charset=utf-8" }

                await response.Content.ReadAsStringAsync()
                Result: HTML page as a string
            */
            Console.WriteLine("C# Interactive in action...");
            Console.ReadKey();
        }
    }
}
