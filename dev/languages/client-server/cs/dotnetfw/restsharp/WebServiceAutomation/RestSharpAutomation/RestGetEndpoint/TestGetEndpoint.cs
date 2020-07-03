using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharp.Authenticators;
using RestSharpAutomation.Helpers.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceAutomation.Model;
using WebServiceAutomation.Model.XmlModel;

namespace RestSharpAutomation.RestGetEndpoint
{
    [TestClass]
    public class TestGetEndpoint
    {
        private readonly string getUrl = "http://localhost:8080/laptop-bag/webapi/api/all";
        private readonly string secureGet = "http://localhost:8080/laptop-bag/webapi/secure/all";
        
        [TestMethod]
        public void TestGetUsingRestSharp()
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(getUrl);
            IRestResponse restResponse = restClient.Get(restRequest);
            Console.WriteLine(restResponse.IsSuccessful);
            Console.WriteLine(restResponse.StatusCode);
            Console.WriteLine(restResponse.ErrorMessage);
            // Return stack trace via ErrorException()
            Console.WriteLine(restResponse.ErrorException);

            if (restResponse.IsSuccessful)
            {
                Console.WriteLine(restResponse.Content);
            }
        }

        [TestMethod]
        public void TestGetXml()
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(getUrl);
            restRequest.AddHeader("Accept", "application/xml");
            IRestResponse restResponse = restClient.Get(restRequest);

            if (restResponse.IsSuccessful)
            {
                Console.WriteLine(restResponse.Content);
            }
        }

        [TestMethod]
        public void TestGetJson()
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(getUrl);
            restRequest.AddHeader("Accept", "application/json");
            IRestResponse restResponse = restClient.Get(restRequest);

            if (restResponse.IsSuccessful)
            {
                Console.WriteLine(restResponse.Content);
            }
        }

        [TestMethod]
        public void TestGetDeserializedAsJson()
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(getUrl);
            restRequest.AddHeader("Accept", "application/json");
            IRestResponse<List<JsonRootObject>> restResponse = restClient.Get<List<JsonRootObject>>(restRequest);

            if (restResponse.IsSuccessful)
            {
                Console.WriteLine($"Status Code: {restResponse.StatusCode}");
                Assert.AreEqual(200, (int)restResponse.StatusCode);
                Console.WriteLine($"Size: {restResponse.Data.Count}");

                List<JsonRootObject> data = restResponse.Data;

                JsonRootObject jsonRootObject = data.Find((x) =>
                {
                    return x.Id == 1;
                });

                Assert.AreEqual("Alienware M17", jsonRootObject.LaptopName);
                Assert.IsTrue(jsonRootObject.Features.Feature.Contains("i5"), "Record not found.");
            }
            else
            {
                Console.WriteLine($"{restResponse.ErrorMessage}");
                Console.WriteLine($"{restResponse.ErrorException}");
            }
        }

        [TestMethod]
        public void TestGetDeserializedAsXml()
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest(getUrl);
            restRequest.AddHeader("Accept", "application/xml");

            var dotNetXmlDeserializer = new RestSharp.Deserializers.DotNetXmlDeserializer();

            // IRestResponse<LaptopDetailss> restResponse = restClient.Get<LaptopDetailss>(restRequest);
            IRestResponse restResponse = restClient.Get(restRequest);

            if (restResponse.IsSuccessful)
            {
                Console.WriteLine($"Status Code: {restResponse.StatusCode}");
                Assert.AreEqual(200, (int)restResponse.StatusCode);

                LaptopDetailss data = dotNetXmlDeserializer.Deserialize<LaptopDetailss>(restResponse);
                Console.WriteLine($"Size: {data.Laptop.Count}");

                Laptop laptop = data.Laptop.Find((x) =>
                {
                    return x.Id.Equals("1", StringComparison.OrdinalIgnoreCase);
                });
            }
            else
            {
                Console.WriteLine($"{restResponse.ErrorMessage}");
                Console.WriteLine($"{restResponse.ErrorException}");
            }
        }

        [TestMethod]
        public void TestGetWithExecute()
        {
            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest()
            {
                Method = Method.GET,
                Resource = getUrl
            };

            restRequest.AddHeader("Accept", "application/json");

            IRestResponse<List<Laptop>> restResponse = restClient.Execute<List<Laptop>>(restRequest);

            Assert.AreEqual(200, (int)restResponse.StatusCode);
            Assert.IsNotNull(restResponse.Data, "Response is null.");
        }

        [TestMethod]
        public void TestGetWithXmlUsingHelperClass()
        {
            Dictionary<string, string> header = new Dictionary<string, string>()
            {
                { "Accept", "application/xml" }
            };

            RestClientHelper restClientHelper = new RestClientHelper();
            
            IRestResponse restResponse = restClientHelper.PerformGetRequest(getUrl, header);
            Assert.AreEqual(200, (int)restResponse.StatusCode);
            Assert.IsNotNull(restResponse.Content, "Response Content is null.");

            IRestResponse<LaptopDetailss> restResponse1 = restClientHelper.PerformGetRequest<LaptopDetailss>(getUrl, header);
            Assert.AreEqual(200, (int)restResponse.StatusCode);
            Assert.IsNotNull(restResponse1.Data, "Response Content is null.");
        }

        [TestMethod]
        public void TestGetWithJsonUsingHelperClass()
        {
            Dictionary<string, string> header = new Dictionary<string, string>()
            {
                { "Accept", "application/json" }
            };

            RestClientHelper restClientHelper = new RestClientHelper();

            IRestResponse restResponse = restClientHelper.PerformGetRequest(getUrl, header);
            Assert.AreEqual(200, (int)restResponse.StatusCode);
            Assert.IsNotNull(restResponse.Content, "Response Content is null.");

            IRestResponse<List<Laptop>> restResponse1 = restClientHelper.PerformGetRequest<List<Laptop>>(getUrl, header);
            Assert.AreEqual(200, (int)restResponse.StatusCode);
            Assert.IsNotNull(restResponse1.Data, "Response Content is null.");
        }

        [TestMethod]
        public void TestSecureGet()
        {
            IRestClient client = new RestClient();
            client.Authenticator = new HttpBasicAuthenticator("admin", "welcome");
            IRestRequest request = new RestRequest()
            { 
                Resource = secureGet
            };

            IRestResponse response = client.Get(request);
            Assert.AreEqual(200, (int)response.StatusCode);
        }
    }
}
