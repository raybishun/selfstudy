using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AdalConsoleAppPrototypes
{
    class Program
    {
        static readonly AzureAppRegInfo azureAppRegInfo = new AzureAppRegInfo();

        static async Task Main(string[] args)
        {
            Console.WriteLine(await GetHttpResponseMessage());
        }

        static async Task<HttpResponseMessage> GetHttpResponseMessage()
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, azureAppRegInfo.RequestUri);
            httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", await azureAppRegInfo.GetToken());
            HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
            return httpResponseMessage;
        }
    }
}
