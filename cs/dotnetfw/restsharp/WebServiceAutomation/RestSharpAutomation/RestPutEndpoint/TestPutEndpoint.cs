using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharpAutomation.Helpers.Request;
using System;
using System.Collections.Generic;
using WebServiceAutomation.Model;

namespace RestSharpAutomation.RestPutEndpoint
{
    [TestClass]
    public class TestPutEndpoint
    {
        private readonly string postUrl = "http://localhost:8080/laptop-bag/webapi/api/add";
        private readonly string getUrl = "http://localhost:8080/laptop-bag/webapi/api/find/";
        private readonly string putUrl = "http://localhost:8080/laptop-bag/webapi/api/update";
        private Random random = new Random();

        [TestMethod]
        public void TestPutWithJsonData()
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

            #region jsonData
            jsonData = "{" +
                                    "\"BrandName\": \"Alienware\"," +
                                    "\"Features\": {" +
                                    "\"Feature\": [" +
                                    "\"8th Generation Intel Core i5-8300H\"," +
                                    "\"windows 10 Home 64-bit English\"," +
                                    "\"NVIDIA GeForce GTX 1660 Ti 6GB GDDR6\"," +
                                    "\"8GB, 2x4GB, DDR4, 2666Mhz\"," +
                                    "\"New Feature\"" +
                                    "]" +
                                    "}," +
                                    "\"Id\": " + id + "," +
                                    "\"LaptopName\": \"Alienware M17\"" +
                                "}";
            #endregion

            IRestClient client = new RestClient();
            IRestRequest request = new RestRequest()
            {
                Resource = putUrl
            };

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(jsonData);

            IRestResponse<JsonRootObject> response1 = client.Put<JsonRootObject>(request);
            Assert.IsTrue(response1.Data.Features.Feature.Contains("New Feature"), "Feature not found.");

            header = new Dictionary<string, string>()
            {
                { "Content-Type", "application/json"},
            };

            response1 = helper.PerformGetRequest<JsonRootObject>($"{getUrl}{id}", header);
            Assert.AreEqual(200, (int)response1.StatusCode);
            Assert.IsTrue(response1.Data.Features.Feature.Contains("New Feature"), "Feature not found.");
        }
    }
}
