using System;
using System.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebServiceAutomation
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HttpClient httpClient = new HttpClient();

            string getUrl = "http://localhost:8080/laptop-bag/webapi/api/all";

            

            httpClient.Dispose();
        }
    }
}
