using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using WebAPI.Models.ComplexData;
using WebAPI.Models.SingleObject;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // Using a hosted REST-API to respond to requests at: https://reqres.in/
        static string baseUrl = "https://reqres.in/";
        static string resource = "/api/users/2";

        static IRestClient client = new RestClient(baseUrl);
        static IRestRequest request = new RestRequest(resource, DataFormat.Json);
        static IRestResponse response = client.Get(request);

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { response.Content };
        }

        [HttpGet("Get1")]
        public Data GetComplexData()
        {
            var root = JsonConvert.DeserializeObject<Root>(response.Content);

            return root.Data;
        }

        [HttpGet("Get2")]
        public User2 GetUser2()
        {
            // Using a hosted REST-API that respond to requests at: https://jsonplaceholder.typicode.com/

            string baseUrl = "https://jsonplaceholder.typicode.com/";
            string resource = "/todos/1";

            IRestClient client = new RestClient(baseUrl);
            IRestRequest request = new RestRequest(resource, DataFormat.Json);
            IRestResponse response = client.Get(request);

            var user2 = JsonConvert.DeserializeObject<User2>(response.Content);

            return user2;
        }
    }
}
