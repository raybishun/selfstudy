using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System.Net;
using WebServiceAutomation.Model.XmlModel;

namespace RestSharpAutomation.QueryParameter
{
    [TestClass]
    public class TestQueryParameter
    {
        private readonly string searchUrl = "http://localhost:8080/laptop-bag/webapi/api/query";
        
        [TestMethod]
        public void TestQueryString()
        {
            IRestClient client = new RestClient();

            IRestRequest request = new RestRequest() { Resource = searchUrl };
            request.AddHeader("Accept", "application/xml");

            // Option #1
            // request.AddParameter("id", "1", ParameterType.QueryString);

            // Option #2
            request.AddQueryParameter("id", "1");
            request.AddQueryParameter("laptopName", "Alienware M17");

            IRestResponse<Laptop> response = client.Get<Laptop>(request);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual("Alienware", response.Data.BrandName);
        }
    }
}
