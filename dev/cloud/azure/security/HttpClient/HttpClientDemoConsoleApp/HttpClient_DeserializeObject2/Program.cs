using HttpClient_DeserializeObject2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HttpClient_DeserializeObject2
{
    class Program
    {
        static readonly string uriString = "https://api.github.com";

        static async Task Main(string[] args)
        {
            using HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(uriString),
            };

            client.DefaultRequestHeaders.Add("User-Agent", "My .NET Core Console App");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // string requestUri = "repos/raybishun/selfstudy/contributors";
            string requestUri = "repos/dotnet/core/contributors";

            HttpResponseMessage response = await client.GetAsync(requestUri);
            response.EnsureSuccessStatusCode();
            var strResult = await response.Content.ReadAsStringAsync();

            List<Contributor> contributors = JsonConvert.DeserializeObject<List<Contributor>>(strResult);
            contributors.ForEach(Console.WriteLine);
        }
    }
}
