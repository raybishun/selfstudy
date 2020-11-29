using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MdeAdalMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            #region Notes
            // Token valid for 1 hour
            // Decode token at: https://jwt.ms/
            #endregion

            string path = @"C:\Users\raybi\AppData\Roaming\Microsoft\UserSecrets\c90d23dd-26f6-41e0-a8e4-d5e09e2f6850\secrets.json";

            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(path, true, true)
                .Build();

            string tenantId = config["TenantId"];
            string appId = config["AppId"];
            string appSecret = config["AppSecret"];

            string authority = "https://login.windows.net";
            string wdatpResourceId = "https://api.securitycenter.windows.com";

            AuthenticationContext authContext = new AuthenticationContext($"{authority}/{tenantId}");
            ClientCredential clientCredential = new ClientCredential(appId, appSecret);
            AuthenticationResult authResult = authContext.AcquireTokenAsync(wdatpResourceId, clientCredential).GetAwaiter().GetResult();

            string token = authResult.AccessToken; 
            Console.WriteLine(token);
        }
    }
}
