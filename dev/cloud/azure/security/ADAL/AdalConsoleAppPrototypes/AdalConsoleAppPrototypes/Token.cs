using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Threading.Tasks;

namespace AdalConsoleAppPrototypes
{
    class Token
    {
        public static async Task<string> GetToken()
        {
            string path = @"C:\Users\raybi\AppData\Roaming\Microsoft\UserSecrets\544a3da6-1731-45f0-a62d-24ad835ac991\secrets.json";
            IConfiguration config = new ConfigurationBuilder().AddJsonFile(path, true, true).Build();

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
            AuthenticationResult authResult = await authContext.AcquireTokenAsync(resourceId, clientCredential);
            return authResult.AccessToken;
        }
    }
}
