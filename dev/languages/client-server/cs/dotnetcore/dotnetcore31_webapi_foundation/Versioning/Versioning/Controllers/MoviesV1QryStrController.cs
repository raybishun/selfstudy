using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Versioning.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

// ============================================================================
// Versioning using Query Strings
// ============================================================================

namespace Versioning.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/movies")]
    [ApiController]
    public class MoviesV1QryStrController : ControllerBase
    {
        static List<MoviesV1> _movies = new List<MoviesV1>()
        {
            new MoviesV1() {Id = 0, MovieName = "Mission Impossible"},
            new MoviesV1() {Id = 1, MovieName = "JumanJi"}
        };

        // GET: https://localhost:44300/api/movies?api-version=1.0
        [HttpGet]
        public IEnumerable<MoviesV1> Get()
        {
            return _movies;
        }

        // GET: https://localhost:44300/api/movies/1?api-version=1.0
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
