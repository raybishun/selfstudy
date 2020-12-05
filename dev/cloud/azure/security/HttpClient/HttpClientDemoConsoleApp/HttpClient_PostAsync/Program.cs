using HttpClient_PostAsync.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpClient_PostAsync
{
    class Program
    {
        static readonly string requestUri = "https://httpbin.org/post";

        static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            Person person = new Person
            {
                Name = "Peter Parker",
                Occupation = "Superhero"
            };

            Console.WriteLine(await PostPersonAsync(person));
        }

        static async Task<string> PostPersonAsync(Person person)
        {
            string jsonResult = JsonConvert.SerializeObject(person);

            // Note: "application/json" is the official Internet media type for JSON
            StringContent data = new StringContent(jsonResult, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(requestUri, data);

            return await response.Content.ReadAsStringAsync();
        }
    }
}
