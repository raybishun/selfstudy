using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace manageappsecrets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecretsController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        public SecretsController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var conStr = Configuration["ConnectionString"];
            return Ok($"{conStr}");


            // return Ok("Ok");
        }
    }
}


// https://localhost:5001/api/secrets
