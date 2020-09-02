using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Models;
using System.Collections.Generic;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>()
        {
          new Character(),
          new Character {Name = "Sam"}
        };

        // [Route("GetAll")]
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(characters);

            // dotnet run
            // Postman GET: http://localhost:5000/character
        }

        public IActionResult GetSingle()
        {
            return Ok(characters[0]);
        }
    }
}