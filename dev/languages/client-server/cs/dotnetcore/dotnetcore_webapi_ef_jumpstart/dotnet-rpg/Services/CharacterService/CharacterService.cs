using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>()
        {
          new Character(),
          new Character { Id = 1, Name = "Sam" }
        };

        public async Task<List<Character>> GetAllCharacters()
        {
            return characters;
        }

        public async Task<Character> GetCharacterById(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }

        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;

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