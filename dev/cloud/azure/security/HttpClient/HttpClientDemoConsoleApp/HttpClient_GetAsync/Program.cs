using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClient_GetAsync
{
    class Program
    {
        static readonly string requestUri = "https://jsonplaceholder.typicode.com/todos";

        static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            HttpResponseMessage data = await GetResponseMessageAsync();

            // Get status code
            Console.WriteLine(data.StatusCode);
            
            // Get data
            Console.WriteLine(await data.Content.ReadAsStringAsync());
        }

        static async Task<HttpResponseMessage> GetResponseMessageAsync()
        {
            // Returns the actual data along with status codes
            return await client.GetAsync(requestUri);
        }
    }
}
