using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AdalConsoleAppPrototypes
{
    class Program
    {
        static readonly AzureAppRegInfo azureAppRegInfo = new AzureAppRegInfo();
        static readonly HttpClient httpClient = new HttpClient();

        static async Task Main(string[] args)
        {
            string uri = azureAppRegInfo.RequestUri;
            string token = await azureAppRegInfo.GetToken();
            
            // Console.WriteLine(await GetHttpResponseMessage(uri, token));
            Console.WriteLine(await GetUserInfo(token, uri));
        }

        static async Task<HttpResponseMessage> GetHttpResponseMessage(string requestUri, string token)
        {
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);
            httpRequestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
            return httpResponseMessage;
        }

        static async Task<User> GetUserInfo(string token, string requestUri)
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            string jsonResult = await httpClient.GetStringAsync(requestUri);
            return JsonConvert.DeserializeObject<User>(jsonResult);
        }
    }
}
