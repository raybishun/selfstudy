using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;

namespace dotnetcore31_security_unittest
{
    [TestClass]
    public class BasicRestRequestUnitTest
    {
        [TestMethod]
        public void TestMethodRestRequest()
        {
            // Using a hosted REST-API to respond to requests at: https://reqres.in/
            string baseUrl = "https://reqres.in/";
            string resource = "/api/users/2";

            IRestClient client = new RestClient(baseUrl);
            IRestRequest request = new RestRequest(resource, DataFormat.Json);
            IRestResponse response = client.Get(request);

            Console.WriteLine(response.Content);
        }
    }
}
