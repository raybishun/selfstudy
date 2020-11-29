using manageappsecretswebapi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace manageappsecretswebapi.Controllers
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
            // Get a connection string
            // ----------------------------------------------------------------
            // var conStr = Config["ConnectionString"];
            // return Ok($"{conStr}");


            // Using a model with secrets
            // ----------------------------------------------------------------
            //var facebook = Config.GetSection("Facebook").Get<Facebook>();
            //return Ok($"Facebook AppSecret: {facebook.AppSecret}, Facebook AppId: {facebook.AppId}");


            // Get local SQL credentials
            // ----------------------------------------------------------------
            var sqlCon = new SqlConnectionStringBuilder("Server=.;Database=MyDb;User Id=reader1");
            sqlCon.Password = Config["DBPassword"];
            return Ok(sqlCon.ToString());
        }
    }
}

// https://localhost:5001/api/secrets
