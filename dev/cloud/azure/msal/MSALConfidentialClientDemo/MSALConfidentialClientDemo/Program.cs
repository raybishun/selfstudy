using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace MSALConfidentialClientDemo
{
    class Program
    {
        static IConfidentialClientApplication _confidentialClientApp;

        static string clientId = "";
        static string tenantId = "";

        static string clientSecret = "";
        
        static Uri authority = new Uri($"");

        static async Task Main(string[] args)
        {
            _confidentialClientApp = ConfidentialClientApplicationBuilder
                .Create(clientId)
                .WithAuthority(authority)
                .WithClientSecret(clientSecret)
                // .WithCertificate() - for use with Azure Key Vault or a Safe Certificate Store
                .Build();

            var scopes = new string[] { "https://graph.microsoft.com/.default" }; // .default used when not using interactive user sign-in

            AuthenticationResult result = await _confidentialClientApp.AcquireTokenForClient(scopes).ExecuteAsync();

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
