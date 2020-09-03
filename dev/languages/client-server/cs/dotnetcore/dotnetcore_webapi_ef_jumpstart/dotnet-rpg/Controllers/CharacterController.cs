using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Models;
using System.Collections.Generic;
using System.Linq;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>()
        {
          new Character(),
          new Character { Id = 1, Name = "Sam" }
        };

        // [Route("GetAll")]
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(characters);

            // dotnet run
            // From Postman GET: http://localhost:5000/character
        }

        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            // return Ok(characters[0]);

            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public IActionResult AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return Ok(characters);

            // dotnet run
            // From Postman POST: http://localhost:5000/character
            // Body: raw
            // Text: JSON
            /*
                {
                    "id": 3,
                    "name": "Percival"
                }
            */
        }
    }
}