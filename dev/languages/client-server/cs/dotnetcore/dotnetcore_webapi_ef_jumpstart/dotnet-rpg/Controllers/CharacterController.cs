using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Models;
using System.Collections.Generic;
using System.Linq;
using dotnet_rpg.Services.CharacterService;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Get()
        {
            return Ok(await _characterService.GetAllCharacters());

            // dotnet run
            // From Postman GET: http://localhost:5000/character
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            // return Ok(characters[0]);

            // return Ok(characters.FirstOrDefault(c => c.Id == id));
            
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddCharacter(Character newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));

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