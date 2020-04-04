using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceAutomation.GetEndpoint
{
    [TestClass]
    public class TestGetEndpoint
    {
        private string getURL = "http://localhost:8080/laptop-bag/webapi/api/all";
        
        [TestMethod]
        public void TestGetAllEndpoint()
        {
            HttpClient httpClient = new HttpClient();

            httpClient.GetAsync(getURL);

            httpClient.Dispose();
        }

        [TestMethod]
        public void TestGetAllEndpointUsingUri()
        {
            HttpClient httpClient = new HttpClient();

            Uri getUri = new Uri(getURL);

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
            Uri getUri = new Uri($"{getURL}_Invalid_Url_Here");

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
    }
}
