using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;

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

        public async Task<string> GetTokenUsingADAL()
        {
            AuthenticationContext authContext = new AuthenticationContext(Authority);
            ClientCredential clientCredential = new ClientCredential(ClientId, ClientSecret);
            AuthenticationResult authResult = await authContext.AcquireTokenAsync(Resource, clientCredential);
            return authResult.AccessToken;
        }

        public async Task<string> GetTokenUsingLegacyWebClient()
        {
            using (var webClient = new WebClient())
            {
                var data = new NameValueCollection
                {
                    { "resource", Resource },
                    { "client_id", ClientId },
                    { "grant_type", "client_credentials" },
                    { "client_secret", ClientSecret }
                };

                string address = $"{Authority}/oauth2/token";
                byte[] bytesResult = await webClient.UploadValuesTaskAsync(address, "POST", data);
                string jsonResult = Encoding.UTF8.GetString(bytesResult);
                Token token = JsonConvert.DeserializeObject<Token>(jsonResult);
                return token.Access_Token;
                // TODO: Check if token is cached
            }
        }
    }
}
