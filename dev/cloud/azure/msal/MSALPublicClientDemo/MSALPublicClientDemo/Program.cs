using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace MSALPublicClientDemo
{
    class Program
    {
        static IPublicClientApplication _publicClientApp;
        
        static string clientId = "";
        static string tenantId = "";

        static Uri authority = new Uri($"");

        static async Task Main(string[] args)
        {
            _publicClientApp = PublicClientApplicationBuilder
                .Create(clientId)
                .WithAuthority(authority)
                .WithRedirectUri("http://localhost")
                .Build();

            var scopes = new string[] { "https://graph.microsoft.com/Sites.Read.All" };

            AuthenticationResult result = await _publicClientApp.AcquireTokenInteractive(scopes).ExecuteAsync();

            Console.WriteLine(result.AccessToken);

            var httpClient = new HttpClient();
            var httpRequest = new HttpRequestMessage(HttpMethod.Get,
                "https://graph.microsoft.com/v1.0/sites/bitsbytescom.sharepoint.com:root/");

            httpRequest.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", result.AccessToken);

            var response = await httpClient.SendAsync(httpRequest);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(await response.Content.ReadAsStringAsync());
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(await response.Content.ReadAsStringAsync());
            }
        }
    }
}
