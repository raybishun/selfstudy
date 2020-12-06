using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AdalConsoleAppPrototypes.Models;
using Newtonsoft.Json;

namespace AdalConsoleAppPrototypes
{
    class Program
    {
        #region Notes
        // Token valid for 1 hour
        // Decode the JSON Web Token at: https://jwt.ms/
        #endregion

        static readonly AzureAppRegInfo azureAppRegInfo = new AzureAppRegInfo();
        static readonly HttpClient httpClient = new HttpClient();

        static async Task Main(string[] args)
        {
            string requestUri = azureAppRegInfo.RequestUri;
            string token = await azureAppRegInfo.GetTokenUsingADAL();

            // Console.WriteLine(await GetHttpResponseMessage(requestUri, token));
            // Console.WriteLine(await GetUserInfo(token, requestUri));
            Console.WriteLine(await azureAppRegInfo.GetTokenUsingLegacyWebClient());
            // Console.WriteLine(await azureAppRegInfo.GetTokenUsingHttpClient());
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
