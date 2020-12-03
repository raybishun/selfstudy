using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AdalConsoleAppPrototypes
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(await GetHttpResponseMessage());
        }

        static async Task<HttpResponseMessage> GetHttpResponseMessage()
        {
            string requestUri = $"https://graph.microsoft.com/v1.0/users/{Token.Login}";

            HttpClient httpClient = new HttpClient();

            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);

            httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", await Token.GetToken());

            HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

            return httpResponseMessage;
        }
    }
}
