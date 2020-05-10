using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WebServiceAutomation.Helper.Request;
using WebServiceAutomation.Helper.Response;
using WebServiceAutomation.Model;
using WebServiceAutomation.Model.XmlModel;
using WebServiceAutomation.Helper.Authentication;

namespace WebServiceAutomation.GetEndpoint
{
    [TestClass]
    public class TestGetEndpoint
    {
        private string getUrl = "http://localhost:8080/laptop-bag/webapi/api/all";
        private string secureGetUrl = "http://localhost:8080/laptop-bag/webapi/secure/all";
        private string delayGet = "http://localhost:8080/laptop-bag/webapi/delay/all";

        [TestMethod]
        public void TestGetAllEndpoint()
        {
            HttpClient httpClient = new HttpClient();

            httpClient.GetAsync(getUrl);

            httpClient.Dispose();
        }

        [TestMethod]
        public void TestGetAllEndpointUsingUri()
        {
            HttpClient httpClient = new HttpClient();

            Uri getUri = new Uri(getUrl);

            // httpClient.GetAsync(getUri);

            Task<HttpResponseMessage> httpResponse = httpClient.GetAsync(getUri);

            HttpResponseMessage httpResponseMessage = httpResponse.Result;
            
            Console.WriteLine(httpResponseMessage.ToString());

            HttpStatusCode statusCode = httpResponseMessage.StatusCode;

            Console.WriteLine($"Status Code: {statusCode}");
            Console.WriteLine($"Status Code: {(int)statusCode}");

            HttpContent responseContent = httpResponseMessage.Content;

            Task<string> responseData = responseContent.ReadAsStringAsync();

            string data = responseData.Result;

            Console.WriteLine($"{data}");

            httpClient.Dispose();
        }

        [TestMethod]
        public void TestGetAllEndpointWithInvalidUrl()
        {
            HttpClient httpClient = new HttpClient();

            // Modify URL to return a NonFound 404 HTTP error
            Uri getUri = new Uri($"{getUrl}_Invalid_Url_Here");

            Task<HttpResponseMessage> httpResponse = httpClient.GetAsync(getUri);

            HttpResponseMessage httpResponseMessage = httpResponse.Result;

            Console.WriteLine(httpResponseMessage.ToString());

            HttpStatusCode statusCode = httpResponseMessage.StatusCode;

            Console.WriteLine($"Status Code: {statusCode}");
            Console.WriteLine($"Status Code: {(int)statusCode}");

            HttpContent responseContent = httpResponseMessage.Content;

            Task<string> responseData = responseContent.ReadAsStringAsync();

            string data = responseData.Result;

            Console.WriteLine($"{data}");
            
            httpClient.Dispose();
        }

        [TestMethod]
        public void TestGetAllEndpointAsJson()
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestHeaders requestHeaders = httpClient.DefaultRequestHeaders;
            // requestHeaders.Add("Accept", "application/xml");
            requestHeaders.Add("Accept", "application/json");

            Task<HttpResponseMessage> httpResponse = httpClient.GetAsync(getUrl);
            HttpResponseMessage httpResponseMessage = httpResponse.Result;
            Console.WriteLine(httpResponseMessage.ToString());

            HttpStatusCode statusCode = httpResponseMessage.StatusCode;
            Console.WriteLine($"Status Code: {statusCode}");
            Console.WriteLine($"Status Code: {(int)statusCode}");

            HttpContent responseContent = httpResponseMessage.Content;
            Task<string> responseData = responseContent.ReadAsStringAsync();
            string data = responseData.Result;
            Console.WriteLine($"{data}");

            httpClient.Dispose();
        }

        [TestMethod]
        public void TestGetAllEndpointAsXml()
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestHeaders requestHeaders = httpClient.DefaultRequestHeaders;
            requestHeaders.Add("Accept", "application/xml");

            Task<HttpResponseMessage> httpResponse = httpClient.GetAsync(getUrl);
            HttpResponseMessage httpResponseMessage = httpResponse.Result;
            Console.WriteLine(httpResponseMessage.ToString());

            HttpStatusCode statusCode = httpResponseMessage.StatusCode;
            Console.WriteLine($"Status Code: {statusCode}");
            Console.WriteLine($"Status Code: {(int)statusCode}");

            HttpContent responseContent = httpResponseMessage.Content;
            Task<string> responseData = responseContent.ReadAsStringAsync();
            string data = responseData.Result;
            Console.WriteLine($"{data}");

            httpClient.Dispose();
        }

        [TestMethod]
        public void TestGetAllEndpointUsingAcceptHeader()
        {
            MediaTypeWithQualityHeaderValue jsonHeader = new MediaTypeWithQualityHeaderValue("application/json");


            HttpClient httpClient = new HttpClient();
            HttpRequestHeaders requestHeaders = httpClient.DefaultRequestHeaders;
            requestHeaders.Accept.Add(jsonHeader);

            Task<HttpResponseMessage> httpResponse = httpClient.GetAsync(getUrl);
            HttpResponseMessage httpResponseMessage = httpResponse.Result;
            Console.WriteLine(httpResponseMessage.ToString());

            HttpStatusCode statusCode = httpResponseMessage.StatusCode;
            Console.WriteLine($"Status Code: {statusCode}");
            Console.WriteLine($"Status Code: {(int)statusCode}");

            HttpContent responseContent = httpResponseMessage.Content;
            Task<string> responseData = responseContent.ReadAsStringAsync();
            string data = responseData.Result;
            Console.WriteLine($"{data}");

            httpClient.Dispose();
        }

        [TestMethod]
        public void GetEndpointUsingSendAsync()
        {
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.RequestUri = new Uri(getUrl);
            httpRequestMessage.Method = HttpMethod.Get;
            httpRequestMessage.Headers.Add("Accept", "application/json");

            HttpClient httpClient = new HttpClient();
            Task<HttpResponseMessage> httpResponse = httpClient.SendAsync(httpRequestMessage);

            HttpResponseMessage httpResponseMessage = httpResponse.Result;
            Console.WriteLine(httpResponseMessage.ToString());

            HttpStatusCode statusCode = httpResponseMessage.StatusCode;
            Console.WriteLine($"Status Code: {statusCode}");
            Console.WriteLine($"Status Code: {(int)statusCode}");

            HttpContent responseContent = httpResponseMessage.Content;
            Task<string> responseData = responseContent.ReadAsStringAsync();
            string data = responseData.Result;
            Console.WriteLine($"{data}");

            httpClient.Dispose();
        }

        [TestMethod]
        public void TestUsingStmt()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpRequestMessage httpRequestMessage = new HttpRequestMessage())
                {
                    httpRequestMessage.RequestUri = new Uri(getUrl);
                    httpRequestMessage.Method = HttpMethod.Get;
                    httpRequestMessage.Headers.Add("Accept", "application/json");

                    Task<HttpResponseMessage> httpResponse = httpClient.SendAsync(httpRequestMessage);

                    using (HttpResponseMessage httpResponseMessage = httpResponse.Result)
                    {
                        Console.WriteLine(httpResponseMessage.ToString());

                        HttpStatusCode statusCode = httpResponseMessage.StatusCode;
                        //Console.WriteLine($"Status Code: {statusCode}");
                        //Console.WriteLine($"Status Code: {(int)statusCode}");

                        HttpContent responseContent = httpResponseMessage.Content;
                        Task<string> responseData = responseContent.ReadAsStringAsync();
                        string data = responseData.Result;
                        //Console.WriteLine($"{data}");

                        // The below RestResponse Class is an alternate way of returning data
                        // And eliminates the need for the above 3 remarked statements

                        RestResponse restResponse = new RestResponse() { StatusCode = (int)statusCode, ResponseContent = responseData.Result };

                        Console.WriteLine(restResponse.ToString());
                    }
                }
            }
        }

        [TestMethod]
        public void TestDeserializationOfJsonResponse()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpRequestMessage httpRequestMessage = new HttpRequestMessage())
                {
                    httpRequestMessage.RequestUri = new Uri(getUrl);
                    httpRequestMessage.Method = HttpMethod.Get;
                    httpRequestMessage.Headers.Add("Accept", "application/json");

                    Task<HttpResponseMessage> httpResponse = httpClient.SendAsync(httpRequestMessage);

                    using (HttpResponseMessage httpResponseMessage = httpResponse.Result)
                    {
                        Console.WriteLine(httpResponseMessage.ToString());

                        HttpStatusCode statusCode = httpResponseMessage.StatusCode;

                        HttpContent responseContent = httpResponseMessage.Content;
                        Task<string> responseData = responseContent.ReadAsStringAsync();
                        string data = responseData.Result;

                        //RestResponse restResponse = new RestResponse((int)statusCode, responseData.Result);

                        RestResponse restResponse = new RestResponse() { StatusCode = (int)statusCode, ResponseContent = responseData.Result };
                        // Console.WriteLine(restResponse.ToString());

                        List<JsonRootObject> jsonRootObject = JsonConvert.DeserializeObject<List<JsonRootObject>>(restResponse.ResponseContent);
                        Console.WriteLine(jsonRootObject[0].ToString());
                    }
                }
            }
        }

        [TestMethod]
        public void TestDeserializationOfXmlResponse()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                using (HttpRequestMessage httpRequestMessage = new HttpRequestMessage())
                {
                    httpRequestMessage.RequestUri = new Uri(getUrl);
                    httpRequestMessage.Method = HttpMethod.Get;
                    httpRequestMessage.Headers.Add("Accept", "application/xml");

                    Task<HttpResponseMessage> httpResponse = httpClient.SendAsync(httpRequestMessage);

                    using (HttpResponseMessage httpResponseMessage = httpResponse.Result)
                    {
                        Console.WriteLine(httpResponseMessage.ToString());

                        HttpStatusCode statusCode = httpResponseMessage.StatusCode;

                        HttpContent responseContent = httpResponseMessage.Content;
                        Task<string> responseData = responseContent.ReadAsStringAsync();
                        string data = responseData.Result;

                        RestResponse restResponse = new RestResponse() { StatusCode = (int)statusCode, ResponseContent = responseData.Result };

                        XmlSerializer xmlSerializer = new XmlSerializer(typeof(LaptopDetailss));

                        TextReader textReader = new StringReader(restResponse.ResponseContent);

                        LaptopDetailss xmlData = (LaptopDetailss)xmlSerializer.Deserialize(textReader);

                        Console.WriteLine(xmlData.ToString());

                        // Assertions
                        Assert.AreEqual(200, restResponse.StatusCode);
                        Assert.IsNotNull(restResponse.ResponseContent);
                        //Assert.IsTrue(xmlData.Laptop.Features.Feature.Contains("Windows 10 Home 64-bit English"), "Item not found.");
                        //Assert.AreEqual("Alienware", xmlData.Laptop.BrandName);
                    }
                }
            }
        }

        [TestMethod]
        public void GetUsingHelperMethod()
        {
            Dictionary<string, string> httpHeader = new Dictionary<string, string>();
            httpHeader.Add("Accept", "application/json");

            RestResponse restResponse = HttpClientHelper.PerformGetRequest(getUrl, httpHeader);

            //List<JsonRootObject> jsonRootObject =
            //    JsonConvert.DeserializeObject<List<JsonRootObject>>(restResponse.ResponseContent);
            //Console.WriteLine(jsonRootObject[0].ToString());

            // Handling a single JsonRootObject
            //JsonRootObject jsonData =
            //    ResponseDataHelper.DeserializeJsonResponse<JsonRootObject>(restResponse.ResponseContent);

            // A single JsonRootObject a list of JsonRootObjects
            List<JsonRootObject> jsonData =
                ResponseDataHelper.DeserializeJsonResponse<List<JsonRootObject>>(restResponse.ResponseContent);

            Console.WriteLine(jsonData.ToString());
        }

        [TestMethod]
        public void TestSecureGetEndpoint()
        {
            Dictionary<string, string> httpHeader = new Dictionary<string, string>();
            httpHeader.Add("Accept", "application/json");
            // httpHeader.Add("Authorization", "Basic YWRtaW46d2VsY29tZQ==");
            string authHeader = Base64StringConverter.GetBsae64String("admin", "welcome");
            httpHeader.Add("Authorization", $"Basic {authHeader}");


            RestResponse restResponse = HttpClientHelper.PerformGetRequest(secureGetUrl, httpHeader);

            //List<JsonRootObject> jsonRootObject =
            //    JsonConvert.DeserializeObject<List<JsonRootObject>>(restResponse.ResponseContent);
            //Console.WriteLine(jsonRootObject[0].ToString());

            // Handling a single JsonRootObject
            //JsonRootObject jsonData =
            //    ResponseDataHelper.DeserializeJsonResponse<JsonRootObject>(restResponse.ResponseContent);

            Assert.AreEqual(200, restResponse.StatusCode);
            
            List<JsonRootObject> jsonData =
                ResponseDataHelper.DeserializeJsonResponse<List<JsonRootObject>>(restResponse.ResponseContent);

            Console.WriteLine(jsonData.ToString());
        }

        [TestMethod]
        public void TestGetEndpoint_Sync()
        {
            HttpClientHelper.PerformGetRequest(delayGet, null);

            HttpClientHelper.PerformGetRequest(delayGet, null);

            HttpClientHelper.PerformGetRequest(delayGet, null);

            HttpClientHelper.PerformGetRequest(delayGet, null);
        }

        [TestMethod]
        public void TestGetEndpoint_Async()
        {
            Task t1 = new Task(GetEndpoint());
            t1.Start();

            Task t2 = new Task(GetEndpoint());
            t2.Start();

            Task t3 = new Task(GetEndpoint());
            t3.Start();

            Task t4 = new Task(GetEndpointFailed());
            t4.Start();

            t1.Wait();
            t2.Wait();
            t3.Wait();
            t4.Wait();
        }
       
        private Action GetEndpoint()
        {
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "Accept", "application/xml" }
            };
            
            return new Action(() => 
            { 
                RestResponse restResponse = HttpClientHelper.PerformGetRequest(delayGet, headers);
                Assert.AreEqual(200, restResponse.StatusCode);
            
            });
        }

        private Action GetEndpointFailed()
        {
            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "Accept", "application/xml" }
            };

            return new Action(() =>
            {
                RestResponse restResponse = HttpClientHelper.PerformGetRequest(delayGet, headers);
                Assert.AreEqual(201, restResponse.StatusCode);
            });
        }
    }
}
