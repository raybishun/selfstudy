using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebServiceAutomation.Model;

namespace WebServiceAutomation.PostEndpoint
{
    [TestClass]
    public class TestPostEndpoint
    {
        private string postUrl = "http://localhost:8080/laptop-bag/webapi/api/add";
        private string getUrl = "http://localhost:8080/laptop-bag/webapi/api/find";
        private RestResponse restResponse;
        private RestResponse restResponseForGet;
        private string jsonMediaType = "application/json";
        private string xmlMediaType = "application/xml";
        private Random random = new Random();

        [TestMethod]
        public void TestPostEndointUsingJson()
        {
            int id = random.Next(1000);
            
            string jsonData =   "{" +
                                    "\"BrandName\": \"Alienware\","+
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

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Accept", jsonMediaType);
                
                HttpContent httpContent = new StringContent(jsonData, Encoding.UTF8, jsonMediaType);
                Task<HttpResponseMessage> postResponse = httpClient.PostAsync(postUrl, httpContent);
                HttpStatusCode statusCode = postResponse.Result.StatusCode;
                HttpContent responseContent = postResponse.Result.Content;
                string responseData = responseContent.ReadAsStringAsync().Result;

                restResponse = new RestResponse((int)statusCode, responseData);

                Assert.AreEqual(200, restResponse.StatusCode);
                Assert.IsNotNull(restResponse.ResponseContent, "Response data is null/empty.");

                Task<HttpResponseMessage> getResponse = httpClient.GetAsync(getUrl + id);

                restResponseForGet = 
                    new RestResponse((int)getResponse.Result.StatusCode, 
                    getResponse.Result.Content.ReadAsStringAsync().Result);

                JsonRootObject jsonObject = 
                    JsonConvert.DeserializeObject<JsonRootObject>(restResponseForGet.ResponseContent);

                Assert.AreEqual(id, jsonObject.Id);
                Assert.AreEqual("Alienware", jsonObject.BrandName);
            }
        }

        [TestMethod]
        public void TestPostUsingXml()
        {
            int id = random.Next(1000);

            string xmlData = "<Laptop>" +
                                "<BrandName>Alienware</BrandName>" +
                                "<Features>" +
                                    "<Feature>8th Generation Intel Core i5-8300H</Feature>" +
                                    "<Feature>Windows 10 Home 64-bit English</Feature>" +
                                    "<Feature>NVIDIA GeForce GTX 1660 Ti 6GB GDDR6</Feature>" +
                                    "<Feature>8GB, 2x4GB, DDR4, 2666Mhz</Feature>" +
                                "</Features>" +
                                  "<Id>" + id + "</id>" +
                                  "<LaptopName>Alienware M17</LaptopName>" +
                              "</Laptop>";

            using (HttpClient httpClient = new HttpClient())
            {
                HttpContent httpContent = 
                    new StringContent(xmlData, Encoding.UTF8, xmlMediaType);

                Task<HttpResponseMessage> httpResponseMessage = 
                    httpClient.PostAsync(postUrl, httpContent);

                restResponse = 
                    new RestResponse((int)httpResponseMessage.Result.StatusCode, 
                    httpResponseMessage.Result.Content.ReadAsStringAsync().Result);

                Assert.AreEqual(200, restResponse.StatusCode);
                Assert.IsNotNull(restResponse.ResponseContent, "Response Data is null/empty.");

                Console.WriteLine(restResponse.ToString());
            }
        }
    }
}