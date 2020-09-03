using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Models;
using System.Collections.Generic;
using System.Linq;
using dotnet_rpg.Services.CharacterService;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        // private static List<Character> characters = new List<Character>()
        // {
        //   new Character(),
        //   new Character { Id = 1, Name = "Sam" }
        // };
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

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