using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebServiceAutomation.Helper.Request;
using WebServiceAutomation.Helper.Response;
using WebServiceAutomation.Model;
using WebServiceAutomation.Model.XmlModel;

namespace WebServiceAutomation.DeleteEndpoint
{
    [TestClass]
    public class TestDeleteEndpoint
    {
        private string postUrl = "http://localhost:8080/laptop-bag/webapi/api/add";
        private string deleteUrl = "http://localhost:8080/laptop-bag/webapi/api/delete/";
        private RestResponse restResponse;
        private string xmlMediaType = "application/xml";
        private Random random = new Random();

        [TestMethod]
        public void TestDelete()
        {
            int id = random.Next(1000);

            AddRecord(id);

            using (HttpClient httpClient= new HttpClient())
            {
                Task<HttpResponseMessage> httpResponseMessage = httpClient.DeleteAsync(deleteUrl + id);
                HttpStatusCode httpStatusCode = httpResponseMessage.Result.StatusCode;
                Assert.AreEqual(200, (int)httpStatusCode);

                httpResponseMessage = httpClient.DeleteAsync(deleteUrl + id);
                httpStatusCode = httpResponseMessage.Result.StatusCode;
                Assert.AreEqual(404, (int)httpStatusCode);
            }
        }

        [TestMethod]
        public void AddRecord(int id)
        {
            string xmlData = "<Laptop>" +
                                 "<BrandName>Alienware</BrandName>" +
                                 "<Features>" +
                                     "<Feature>8th Generation Intel Core i5-8300H</Feature>" +
                                     "<Feature>Windows 10 Home 64-bit English</Feature>" +
                                     "<Feature>NVIDIA GeForce GTX 1660 Ti 6GB GDDR6</Feature>" +
                                     "<Feature>8GB, 2x4GB, DDR4, 2666Mhz</Feature>" +
                                 "</Features>" +
                                   "<Id>" + id + "</Id>" +
                                   "<LaptopName>Alienware M17</LaptopName>" +
                               "</Laptop>";

            Dictionary<string, string> headers = new Dictionary<string, string>()
            {
                { "Accept", "application/xml"}
            };

            restResponse = HttpClientHelper.PerformPostRequest(postUrl, xmlData, xmlMediaType, headers);

            // HttpContent httpContent = new StringContent(xmlData, Encoding.UTF8, xmlMediaType);

            // HttpClientHelper.PerformPostRequest(postUrl, httpContent, headers);

            Assert.AreEqual(200, restResponse.StatusCode);


            Laptop laptop = ResponseDataHelper.DeserializeXmlResponse<Laptop>(restResponse.ResponseContent);
           //  Console.WriteLine(laptop.ToString());
        }

        [TestMethod]
        public void TestDeleteUsingHelperClass()
        {
            int id = random.Next(1000);

            AddRecord(id);

            restResponse = HttpClientHelper.PerformDeleteRequest(deleteUrl + id);
            Assert.AreEqual(200, restResponse.StatusCode);

            restResponse = HttpClientHelper.PerformDeleteRequest(deleteUrl + id);
            Assert.AreEqual(404, restResponse.StatusCode);
        }
    }
}
