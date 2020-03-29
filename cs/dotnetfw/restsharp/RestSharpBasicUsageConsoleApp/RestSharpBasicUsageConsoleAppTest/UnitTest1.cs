using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

using RestSharpBasicUsageConsoleApp;

namespace RestSharpBasicUsageConsoleAppTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // 1. Create a Client
            // 2. Create a Request
            // 3. Get a Response
            // 4. Display the Response

            IRestClient restClient = new RestClient();
            IRestRequest restRequest = new RestRequest();
            
        }
    }
}
