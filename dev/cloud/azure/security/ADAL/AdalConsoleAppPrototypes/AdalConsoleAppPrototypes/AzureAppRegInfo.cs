using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Threading.Tasks;

namespace AdalConsoleAppPrototypes
{
    class AzureAppRegInfo
    {
        public string TenantId { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Login { get; set; }
        public string Authority { get; set; }
        public string Resource { get; set; }
        public string RequestUri { get; set; }

        public AzureAppRegInfo()
        {
            string path = @"C:\Users\raybi\AppData\Roaming\Microsoft\UserSecrets\544a3da6-1731-45f0-a62d-24ad835ac991\secrets.json";
            IConfiguration config = new ConfigurationBuilder().AddJsonFile(path, true, true).Build();

            TenantId        = config["TenantId"];
            ClientId        = config["ClientId"];
            ClientSecret    = config["ClientSecret"];
            Login           = config["Login"];
            Authority       = $"{config["Authority_Option2"]}/{TenantId}";
            Resource        = config["Resource"];
            RequestUri      = $"{config["RequestUri"]}/{Login}";
        }

        public async Task<string> GetToken()
        {
            AuthenticationContext authContext = new AuthenticationContext(Authority);
            ClientCredential clientCredential = new ClientCredential(ClientId, ClientSecret);
            AuthenticationResult authResult = await authContext.AcquireTokenAsync(Resource, clientCredential);
            return authResult.AccessToken;
        }
    }
}
