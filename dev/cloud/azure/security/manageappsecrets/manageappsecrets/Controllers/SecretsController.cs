using manageappsecrets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace manageappsecrets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecretsController : ControllerBase
    {
        public IConfiguration Config { get; }
        public SecretsController(IConfiguration configuration)
        {
            Config = configuration;
        }
        
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            // var conStr = Configuration["ConnectionString"];
            // return Ok($"{conStr}");

            // Read the secrets using a model
            var facebook = Config.GetSection("Facebook").Get<Facebook>();
            return Ok($"Facebook AppSecret: {facebook.AppSecret}, Facebook AppId: {facebook.AppId}");
        }
    }
}


// https://localhost:5001/api/secrets
