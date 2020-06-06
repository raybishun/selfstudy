using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using hello_world.Models;
using Newtonsoft.Json;

namespace hello_world.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string Contact()
        {
            var user = new User {
                UserName = "peter",
                FullName = "peter parker",
                Password = "spiderman"
            };

            var json = JsonConvert.SerializeObject(user, Formatting.Indented);

            return json;
        }

        public string Privacy()
        {
            var user = new User {
                UserName = "peter",
                FullName = "peter parker",
                Password = "spiderman"
            };

            var json = JsonConvert.SerializeObject(user, Formatting.Indented);
            _logger.LogInformation(json);
            throw new Exception("I'm not a happy camper...");
            return json;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
