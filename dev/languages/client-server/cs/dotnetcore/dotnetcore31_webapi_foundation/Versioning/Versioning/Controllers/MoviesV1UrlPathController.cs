using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Versioning.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

// ============================================================================
// Versioning using URL Path Strings, i.e.: api/v1/movies
// ============================================================================

namespace Versioning.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/movies")]
    [ApiController]
    public class MoviesV1UrlPathController : ControllerBase
    {
        static List<MoviesV1> _movies = new List<MoviesV1>()
        {
            new MoviesV1() {Id = 0, MovieName = "Mission Impossible"},
            new MoviesV1() {Id = 1, MovieName = "JumanJi"}
        };

        // GET: https://localhost:44300/api/v1/movies
        [HttpGet]
        public IEnumerable<MoviesV1> Get()
        {
            return _movies;
        }

        // GET: https://localhost:44300/api/v1/movies/1
        [HttpGet("{id}")]
        public IEnumerable<MoviesV1> Get(int id)
        {
            return _movies.Where(m => m.Id == id);
        }

        // POST api/<MoviesV1Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MoviesV1Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MoviesV1Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
