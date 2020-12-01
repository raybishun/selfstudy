using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientIntroConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var results = await GetToDoItems();
            Console.WriteLine(results);
        }

        static async Task<string> GetToDoItems()
        {
            string uri = "https://jsonplaceholder.typicode.com/todos";
            string response;

            try
            {
                HttpClient client = new HttpClient();
                response = await client.GetStringAsync(uri);
            }
            catch (Exception ex)
            {
                response = ex.Message;
            }

            return response;
        }
    }
}
