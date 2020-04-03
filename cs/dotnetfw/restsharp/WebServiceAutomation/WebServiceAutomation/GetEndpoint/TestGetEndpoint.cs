using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
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

            httpClient.GetAsync(getUri);

            httpClient.Dispose();
        }
    }
}
