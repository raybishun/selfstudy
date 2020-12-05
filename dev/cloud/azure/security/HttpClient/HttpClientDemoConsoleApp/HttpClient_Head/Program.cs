using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClient_Header
{
    class Program
    {
        static readonly string requestUri = "https://jsonplaceholder.typicode.com/todos";

        static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            HttpResponseMessage httpHeader = await GetResponseMessageAsync();
            Console.WriteLine(httpHeader);
        }

        static async Task<HttpResponseMessage> GetResponseMessageAsync()
        {
            // Send an HTTP request
            return await client.SendAsync(new HttpRequestMessage(HttpMethod.Head, requestUri));
        }
    }
}
