using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharpAutomation.Helpers.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpAutomation.RestDeleteEndpoint
{
    [TestClass]
    public class TestDeleteEndpoint
    {
        private readonly string postUrl = "http://localhost:8080/laptop-bag/webapi/api/add";
        private readonly string deleteEndpointUrl = "http://localhost:8080/laptop-bag/webapi/api/delete/";
        private Random random = new Random();

        [TestMethod]
        public void TestDeleteRequest()
        {
            int id = random.Next(1000);

            #region jsonData
            string jsonData = "{" +
                                    "\"BrandName\": \"Alienware\"," +
                                    "\"Features\": {" +
                                    "\"Feature\": [" +
                                    "\"8th Generation Intel Core i5-8300H\"," +
                                    "\"windows 10 Home 64-bit English\"," +
                                    "\"NVIDIA GeForce GTX 1660 Ti 6GB GDDR6\"," +
                                    "\"8GB, 2x4GB, DDR4, 2666Mhz\"" +
                                    "]" +
                                    "}," +
                                    "\"Id\": " + id + "," +
                                    "\"LaptopName\": \"Alienware M17\"" +
                                "}";
            #endregion

            Dictionary<string, string> header = new Dictionary<string, string>()
            {
                { "Content-Type", "application/json" },
                { "Accept", "application/json" }
            };

            RestClientHelper helper = new RestClientHelper();

            IRestResponse response =
                helper.PerformPostRequest(postUrl, header, jsonData, DataFormat.Json);
            Assert.AreEqual(200, (int)response.StatusCode);

            IRestClient client = new RestClient();
            IRestRequest request = new RestRequest()
            {
                Resource = $"{deleteEndpointUrl}{id}"
            };

            request.AddHeader("Accept", "*/*");

            IRestResponse response1 = client.Delete(request);
            Assert.AreEqual(200, (int)response1.StatusCode);

            response1 = client.Delete(request);
            Assert.AreEqual(404, (int)response1.StatusCode);
        }

        [TestMethod]
        public void TestDeleteRequestUsingHelper()
        {
            int id = random.Next(1000);

            #region jsonData
            string jsonData = "{" +
                                    "\"BrandName\": \"Alienware\"," +
                                    "\"Features\": {" +
                                    "\"Feature\": [" +
                                    "\"8th Generation Intel Core i5-8300H\"," +
                                    "\"windows 10 Home 64-bit English\"," +
                                    "\"NVIDIA GeForce GTX 1660 Ti 6GB GDDR6\"," +
                                    "\"8GB, 2x4GB, DDR4, 2666Mhz\"" +
                                    "]" +
                                    "}," +
                                    "\"Id\": " + id + "," +
                                    "\"LaptopName\": \"Alienware M17\"" +
                                "}";
            #endregion

            Dictionary<string, string> header = new Dictionary<string, string>()
            {
                { "Content-Type", "application/json" },
                { "Accept", "application/json" }
            };

            RestClientHelper helper = new RestClientHelper();

            IRestResponse response =
                helper.PerformPostRequest(postUrl, header, jsonData, DataFormat.Json);
            Assert.AreEqual(200, (int)response.StatusCode);

            header = new Dictionary<string, string>()
            {
                { "Accept", "*/*" }
            };

            IRestResponse response1 = helper.PerformDeleteRequest($"{deleteEndpointUrl}{id}", header);
            Assert.AreEqual(200, (int)response1.StatusCode);

            response1 = helper.PerformDeleteRequest($"{deleteEndpointUrl}{id}", header);
            Assert.AreEqual(404, (int)response1.StatusCode);
        }
    }
}
