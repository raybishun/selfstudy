using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClient_GetStringAsync
{
    class Program
    {
        static readonly string requestUri = "https://jsonplaceholder.typicode.com/todos";

        static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            Console.WriteLine(await GetToDoListAsync());
        }

        static async Task<string> GetToDoListAsync()
        {
            return await client.GetStringAsync(requestUri);
        }        
    }
}
