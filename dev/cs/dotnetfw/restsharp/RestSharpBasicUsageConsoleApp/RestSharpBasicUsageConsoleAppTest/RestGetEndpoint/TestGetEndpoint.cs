using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharpBasicUsageConsoleApp;

namespace RestSharpBasicUsageConsoleAppTest.RestGetEndpoint
{
    [TestClass]
    public class TestGetEndpoint
    {
        private string url = "https://reqres.in/";

        [TestMethod]
        public void TestGetUsingRestSharp()
        {
            IRestClient client = new RestClient(url);
            IRestRequest request = new RestRequest("/api/users/2", DataFormat.Json);
            request.AddHeader("Accept", "application/json"); // not sure if necessary
            IRestResponse response = client.Get(request);

            if (response.IsSuccessful)
            {
                Console.WriteLine($"{response.Content}");
            }
            else
            {
                Console.WriteLine(response.StatusCode);
                Console.WriteLine(response.ErrorMessage);
                Console.WriteLine(response.ErrorMessage);
            }
        }

        [TestMethod]
        public void TestGetUsingRestSharp_Deserialize()
        {
            IRestClient client = new RestClient(url);
            IRestRequest request = new RestRequest("/api/users/2", DataFormat.Json);
            // request.AddHeader("Accept", "application/json"); // not sure if necessary
            IRestResponse<List<TestDataRootObject>> response = client.Get<List<TestDataRootObject>>(request);

            if (response.IsSuccessful)
            {
                Console.WriteLine($"{response.Data.Count}");
            }
            else
            {
                Console.WriteLine(response.StatusCode);
                Console.WriteLine(response.ErrorMessage);
                Console.WriteLine(response.ErrorMessage);
            }
        }
    }
}
