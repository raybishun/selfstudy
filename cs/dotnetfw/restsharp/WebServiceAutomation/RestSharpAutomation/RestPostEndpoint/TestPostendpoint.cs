using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using RestSharp.Serializers;
using RestSharpAutomation.Helpers.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServiceAutomation.Model.XmlModel;

namespace RestSharpAutomation.RestPostEndpoint
{
    [TestClass]
    public class TestPostEndpoint
    {
        private readonly string postUrl = "http://localhost:8080/laptop-bag/webapi/api/add";
        private readonly Random random = new Random();

        [TestMethod]
        public void TestPostWithJsonData()
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
            IRestClient client = new RestClient();
            IRestRequest request = new RestRequest() { Resource = postUrl };
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/xml");
            request.AddJsonBody(jsonData);
            IRestResponse response = client.Post(request);
            Assert.AreEqual(200, (int)response.StatusCode);
            Console.WriteLine(response.Content);
        }

        private Laptop GetLaptopObject()
        {
            Laptop laptop = new Laptop()
            {
                BrandName = "Lenovo",
                LaptopName = "X1 Extreme"
            };

            Features features = new Features();

            List<string> featureList = new List<string>()
            {
                ("32GB RAM")
            };

            features.Feature = featureList;
            laptop.Id = random.Next(1000).ToString();
            laptop.Features = features;

            return laptop;
        }
        
        [TestMethod]
        public void TestPostWithModelObject()
        {
            IRestClient client = new RestClient();
            IRestRequest request = new RestRequest() { Resource = postUrl };

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/xml");
            request.RequestFormat = DataFormat.Json;
            request.AddBody(GetLaptopObject());
            
            IRestResponse response = client.Post(request);
            Assert.AreEqual(200, (int)response.StatusCode);
            Console.WriteLine(response.Content);
        }

        [TestMethod]
        public void TestPostWithModelObject_HelperClass()
        {
            Dictionary<string, string> header = new Dictionary<string, string>()
            {
                { "Content-Type", "application/json" },
                { "Accept", "application/xml" }
            };

            RestClientHelper restClientHelper = new RestClientHelper();
            IRestResponse<Laptop> response = restClientHelper.PerformPostRequest<Laptop>(
                postUrl, header, GetLaptopObject(), DataFormat.Json);

            Assert.AreEqual(200, (int)response.StatusCode);
            Console.WriteLine(response.Content);
        }

        [TestMethod]
        public void TestPostWithXmlData()
        {
            int id = random.Next(100);
            #region xmlData
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
            #endregion
            IRestClient client = new RestClient();
            IRestRequest request = new RestRequest()
            {
                Resource = postUrl
            };

            request.AddHeader("Content-Type", "application/xml");
            request.AddHeader("Accept", "application/xml");
            request.AddParameter("XmlBody", xmlData, ParameterType.RequestBody);

            IRestResponse<Laptop> response = client.Post<Laptop>(request);
            Assert.AreEqual(200, (int)response.StatusCode);
            Assert.IsNotNull(response.Data, "response.Data is null.");
        }

        [TestMethod]
        public void TestPostWithXmlData_ComplexPayload()
        {
            int id = random.Next(100);
            #region xmlData
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
            #endregion
            IRestClient client = new RestClient();
            IRestRequest request = new RestRequest()
            {
                Resource = postUrl
            };

            request.AddHeader("Content-Type", "application/xml");
            request.AddHeader("Accept", "application/xml");
            request.RequestFormat = DataFormat.Xml;
            request.XmlSerializer = new DotNetXmlSerializer();
            request.AddParameter(
                "XmlBody", request.XmlSerializer.Serialize(GetLaptopObject()), ParameterType.RequestBody);

            IRestResponse<Laptop> response = client.Post<Laptop>(request);
            Assert.AreEqual(200, (int)response.StatusCode);
            Assert.IsNotNull(response.Data, "response.Data is null.");
        }

        [TestMethod]
        public void TestPostWithXml_HelperClass()
        {
            Dictionary<string, string> header = new Dictionary<string, string>()
            {
                { "Content-Type", "application/xml" },
                { "Accept", "application/xml" }
            };

            RestClientHelper helper = new RestClientHelper();

            // Test 1 of 2: Passing an object
            IRestResponse<Laptop> response =
                helper.PerformPostRequest<Laptop>(postUrl, header, GetLaptopObject(), DataFormat.Xml);

            // Test 2 of 2: Passing a string (xmlData)
            #region xmlData
            int id = random.Next(1000);
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
            #endregion
            //IRestResponse<Laptop> response = 
            //    helper.PerformPostRequest<Laptop>(postUrl, header, xmlData, DataFormat.Xml);

            Assert.AreEqual(200, (int)response.StatusCode);
            Assert.IsNotNull(response.Data, "response.Data is null.");
        }
    }
}
