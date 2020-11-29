using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace MdeAdalMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task GetAlertsTestMethod()
        {
            #region Notes
            // Token valid for 1 hour
            // Decode the JSON Web Token at: https://jwt.ms/
            #endregion

            // Manage User-Secrets
            string path = @"C:\Users\raybi\AppData\Roaming\Microsoft\UserSecrets\c90d23dd-26f6-41e0-a8e4-d5e09e2f6850\secrets.json";
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(path, true, true)
                .Build();

            string tenantId = config["TenantId"];
            string appId = config["AppId"];
            string appSecret = config["AppSecret"];

            string authority = "https://login.windows.net";
            string wdatpResourceId = "https://api.securitycenter.windows.com";

            // Get Token
            AuthenticationContext authContext = new AuthenticationContext($"{authority}/{tenantId}");
            ClientCredential clientCredential = new ClientCredential(appId, appSecret);
            AuthenticationResult authResult = authContext.AcquireTokenAsync(wdatpResourceId, clientCredential).GetAwaiter().GetResult();
            string token = authResult.AccessToken; 
            Console.WriteLine($"{token}\n");

            // Get MDE Alerts
            string alertsRequestUri = "https://api.securitycenter.windows.com/api/alerts";
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Get, alertsRequestUri);
            httpRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            HttpResponseMessage response = httpClient.SendAsync(httpRequest).GetAwaiter().GetResult();
            string payload = await response.Content.ReadAsStringAsync();
            Console.WriteLine(payload);
        }
    }
}
