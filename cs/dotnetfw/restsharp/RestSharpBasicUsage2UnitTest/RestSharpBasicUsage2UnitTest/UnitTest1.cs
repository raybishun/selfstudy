using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

            request.AddJsonBody(new Posts() { id="22", author="Ray", title="TheTitle" });

            var response = client.Execute(request);

            var deserialize = new JsonDeserializer();
            var output = deserialize.Deserialize<Dictionary<string, string>>(response);
            var result = output["author"];

            Assert.That(result, Is.EqualTo("Ray"), "Author is invalid.");
        }

        [Test]
        public void PostUsingGenerics()
        {
            var client = new RestClient("http://localhost:3000/");

            var request = new RestRequest("posts", Method.POST);

            request.AddJsonBody(new Posts() { id = "25", author = "Ray", title = "TheTitle" });

            // var response = client.Execute<Posts>(request).Data;
            var response = client.Execute<Posts>(request);

            Assert.That(response.Data.author, Is.EqualTo("Ray"), "Author is invalid.");
        }

        [Test]
        public void PostUsingAsync()
        {
            var client = new RestClient("http://localhost:3000/");

            var request = new RestRequest("posts", Method.POST);

            request.AddJsonBody(new Posts() { id = "26", author = "Ray", title = "TheTitle" });

            // var response = client.Execute<Posts>(request).Data;
            // var response = client.Execute<Posts>(request);

           var response = ExecuteAsyncRequest<Posts>(client, request).GetAwaiter().GetResult();


            Assert.That(response.Data.author, Is.EqualTo("Ray"), "Author is invalid.");
        }

        private async Task<IRestResponse<T>> ExecuteAsyncRequest<T>(RestClient client, IRestRequest request) where T: class, new()
        {
            var taskCompletionSource = new TaskCompletionSource<IRestResponse<T>>();

            client.ExecuteAsync<T>(request, restResponse =>
            {
                if (restResponse.ErrorException != null)
                {
                    const string message = "Error retrieving response.";
                    throw new ApplicationException(message, restResponse.ErrorException);
                }

                taskCompletionSource.SetResult(restResponse);

            });

            return await taskCompletionSource.Task;
        }
    }
}
