using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;
using RestSharpBasicUsage2UnitTest.Model;

namespace RestSharpBasicUsage2UnitTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var client = new RestClient("http://localhost:3000/");

            var request = new RestRequest("posts/{postid}", Method.GET);
            request.AddUrlSegment("postid", 1);

            //var content = client.Execute(request).Content;
            //Console.WriteLine(content);

            var response = client.Execute(request);

            //var deserialize = new JsonDeserializer();
            //var output = deserialize.Deserialize<Dictionary<string, string>>(response);
            //var result = output["author"];
            //Assert.That(result, Is.EqualTo("Diana Prince"), "Author is invalid.");

            // using Newtonsoft (another option)
            JObject obs = JObject.Parse(response.Content);
            Assert.That(obs["author"].ToString(), Is.EqualTo("Diana Prince"), "Author is invalid.");
     
        }

        [Test]
        public void PostWithAnonymousBody()
        {
            var client = new RestClient("http://localhost:3000/");

            var request = new RestRequest("posts/{postid}/profile", Method.POST);

            request.AddJsonBody(new { name = "Ray" });

            request.AddUrlSegment("postid", 1);

            var response = client.Execute(request);

            var deserialize = new JsonDeserializer();
            var output = deserialize.Deserialize<Dictionary<string, string>>(response);
            var result = output["name"];

            Assert.That(result, Is.EqualTo("Ray"), "Author is invalid.");
        }

        [Test]
        public void PostWithStronglyTypedBody()
        {
            var client = new RestClient("http://localhost:3000/");

            var request = new RestRequest("posts", Method.POST);

            request.AddJsonBody(new Posts() { id="17", author="Ray", title="TheTitle" });

            var response = client.Execute(request);

            var deserialize = new JsonDeserializer();
            var output = deserialize.Deserialize<Dictionary<string, string>>(response);
            var result = output["author"];

            Assert.That(result, Is.EqualTo("Ray"), "Author is invalid.");
        }
    }
}
