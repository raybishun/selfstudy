using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;

// Resources
// https://reqres.in/
// http://json2csharp.com/

namespace RestSharpBasicUsageConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // BasicUsage_Twitter();
            BasicUsage_ReqRes();

            Console.ReadLine();
        }

        private static void BasicUsage_ReqRes()
        {
            try
            {
                var client = new RestClient("https://reqres.in/");

                var request = new RestRequest("/api/users/2", DataFormat.Json);

                var response = client.Get(request);

                Console.WriteLine(response.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void BasicUsage_Twitter()
        {
            try
            {
                var client = new RestClient("https://api.twitter.com/1.1")
                {
                    Authenticator = new HttpBasicAuthenticator("username", "password")
                };

                var request = new RestRequest("statuses/home_timeline.json", DataFormat.Json);

                var response = client.Get(request);

                Console.WriteLine(response.StatusDescription);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
