using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Net;

namespace dotnetcore31_security_unittest
{
    [TestClass]
    public class RestUnitTest
    {
        [TestMethod]
        public void TestMethodRestRequest()
        {
            // Arrange
            // ----------------------------------------------------------------
            // Using a hosted REST-API that responds to requests at: https://reqres.in/
            string baseUrl = "https://reqres.in/";
            string resource = "/api/users/2";

            IRestClient client = new RestClient(baseUrl);
            IRestRequest request = new RestRequest(resource, DataFormat.Json);
            IRestResponse response = client.Get(request);

            // Act
            // ----------------------------------------------------------------
            var result = response.StatusCode;
            Console.WriteLine(response.Content);

            // Assert
            // ----------------------------------------------------------------
            Assert.AreEqual(HttpStatusCode.OK, result);
        }
    }
}
