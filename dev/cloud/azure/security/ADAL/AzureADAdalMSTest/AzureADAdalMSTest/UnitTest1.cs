using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
using AzureADAdalMSTest.Models;

namespace AzureADAdalMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task GetUserInfoTestMethod()
        {
            #region Notes
            // Token valid for 1 hour
            // Decode the JSON Web Token at: https://jwt.ms/
            #endregion

            // Manage User-Secrets
            string path = @"C:\Users\raybi\AppData\Roaming\Microsoft\UserSecrets\25abbabd-ee28-4702-831f-b1e783a6a2f1\secrets.json";
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(path, true, true)
                .Build();

            string tenantId = config["TenantId"];
            string appId = config["AppId"];
            string appSecret = config["AppSecret"];
            string login = config["Login"];

            // string authority = $"https://login.windows.net/{tenantId}";
            string authority = $"https://login.microsoftonline.com/{tenantId}";
            
            string resourceId = "https://graph.microsoft.com/";

            // Get Token
            AuthenticationContext authContext = new AuthenticationContext(authority);
            ClientCredential clientCredential = new ClientCredential(appId, appSecret);
            // AuthenticationResult authResult = authContext.AcquireTokenAsync(resourceId, clientCredential).GetAwaiter().GetResult();
            AuthenticationResult authResult = await authContext.AcquireTokenAsync(resourceId, clientCredential);
            string token = authResult.AccessToken;
            Console.WriteLine($"{token}\n");

            // Get AzureAD User Info
            string requestUri = $"https://graph.microsoft.com/v1.0/users/{login}";
            HttpClient client = new HttpClient();

            //var httpRequest = new HttpRequestMessage(HttpMethod.Get, requestUri);
            //httpRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            //var result = await client.SendAsync(httpRequest);
            //Console.WriteLine(result);

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            string result = await client.GetStringAsync(requestUri);
            // Console.WriteLine(result);

            User user = JsonConvert.DeserializeObject<User>(result);
            Console.WriteLine($"{user.UserPrincipalName}\n{user.DisplayName}\n{user.MobilePhone}");
        }
    }
}
