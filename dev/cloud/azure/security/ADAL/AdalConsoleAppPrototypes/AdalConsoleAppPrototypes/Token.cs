using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Threading.Tasks;

namespace AdalConsoleAppPrototypes
{
    class Token
    {
        public static string TenantId { get; set; }
        public static string AppId { get; set; }
        public static string AppSecret { get; set; }
        public static string Login { get; set; }

        static Token()
        {
            string path = @"C:\Users\raybi\AppData\Roaming\Microsoft\UserSecrets\544a3da6-1731-45f0-a62d-24ad835ac991\secrets.json";
            IConfiguration config = new ConfigurationBuilder().AddJsonFile(path, true, true).Build();

            TenantId = config["TenantId"];
            AppId = config["AppId"];
            AppSecret = config["AppSecret"];
            Login = config["Login"];
        }

        public static async Task<string> GetToken()
        {
            // string authority = $"https://login.windows.net/{tenantId}";
            string authority = $"https://login.microsoftonline.com/{TenantId}";
            string resourceId = "https://graph.microsoft.com/";

            // Get Token
            AuthenticationContext authContext = new AuthenticationContext(authority);
            ClientCredential clientCredential = new ClientCredential(AppId, AppSecret);
            AuthenticationResult authResult = await authContext.AcquireTokenAsync(resourceId, clientCredential);
            return authResult.AccessToken;
        }
    }
}
