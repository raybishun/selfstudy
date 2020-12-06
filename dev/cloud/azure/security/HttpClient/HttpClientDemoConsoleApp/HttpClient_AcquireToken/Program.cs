using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using HttpClient_AcquireToken.Models;
using System.Net.Http.Headers;

namespace HttpClient_AcquireToken
{
    class Program
    {
        public static string TenantId { get; set; }
        public static string ClientId { get; set; }
        public static string ClientSecret { get; set; }
        public static string Login { get; set; }
        public static string Authority { get; set; }
        public static string Resource { get; set; }
        public static string RequestUri { get; set; }

        static async Task Main(string[] args)
        {
            string path = @"C:\Users\raybi\AppData\Roaming\Microsoft\UserSecrets\89ce91f3-aa9c-4a48-ac34-ceec31f72fcd\secrets.json";
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(path, true, true)
                .Build();

            TenantId = config["TenantId"];
            ClientId = config["ClientId"];
            ClientSecret = config["ClientSecret"];
            Login = config["Login"];
            Authority = $"{config["Authority_Option2"]}/{TenantId}";
            Resource = config["Resource"];
            RequestUri = $"{config["RequestUri"]}/{Login}";

            Console.WriteLine(await GetTokenUsingHttpClient());
            // Console.WriteLine(await GetTokenUsingLegacyWebClient());
        }

        static async Task<Token> GetTokenUsingHttpClient()
        {
            string credentials = $"{ClientId}:{ClientSecret}";

            using (HttpClient client = new HttpClient())
            {
                // Define Headers
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes(credentials)));

                // Prepare Request Body
                List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
                data.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
                FormUrlEncodedContent requestBody = new FormUrlEncodedContent(data);

                // Request Token
                HttpResponseMessage response = await client.PostAsync($"{Authority}/oauth2/token", requestBody);
                string jsonResult = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Token>(jsonResult);
                
                // TODO: Check if token is cached
            }
        }

        static async Task<Token> GetTokenUsingLegacyWebClient()
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

                return JsonConvert.DeserializeObject<Token>(jsonResult);

                // TODO: Check if token is cached
            }
        }
    }
}
