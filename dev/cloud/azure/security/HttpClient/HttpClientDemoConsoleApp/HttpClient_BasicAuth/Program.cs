using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace HttpClient_BasicAuth
{
    class Program
    {
        #region HttpClient Basic Authentication Notes
        // Requests contain a header field in the form of Authorization: Basic <credentials>
        // Credentials use BASE64 encoding of ID and PASSWORD joined by a single colon :.
        // Credentials are NOT encrypted, so always use with HTTPS
        // Does NOT require cookies/session identifies/login pages
        // Uses standard fields in the HTTP header
        #endregion

        static async Task Main(string[] args)
        {
            string path = @"C:\Users\raybi\AppData\Roaming\Microsoft\UserSecrets\53ff3096-ab13-4b9f-9c5c-c2e5583befa6\secrets.json";
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(path, true, true)
                .Build();

            string user = config["UserName"];
            string passwd = config["Passwd"];

            HttpClient client = new HttpClient();
            string requestUri = "https://httpbin.org/basic-auth/user7/passwd";

            Console.WriteLine(await BasicAuthAsync(client, requestUri, user, passwd));
        }

        static async Task<string> BasicAuthAsync(HttpClient client, string requestUri, string user, string passwd)
        {
            byte[] authToken = Encoding.ASCII.GetBytes($"{user}:{passwd}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authToken));
            HttpResponseMessage result = await client.GetAsync(requestUri);
            return await result.Content.ReadAsStringAsync();
        }
    }
}
