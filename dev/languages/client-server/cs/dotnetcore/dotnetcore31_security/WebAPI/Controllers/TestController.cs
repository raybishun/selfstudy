using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serialization.Json;
using WebAPI.Models;

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

        public IEnumerable<string> Get()
        {
            return new string[] { response.Content };
        }

        [HttpGet("GetUser")]
        public User Get_User()
        {
            var d = new JsonDeserializer();

            var ouput = d.Deserialize<User>(response);

            return ouput;
        }
    }
}
