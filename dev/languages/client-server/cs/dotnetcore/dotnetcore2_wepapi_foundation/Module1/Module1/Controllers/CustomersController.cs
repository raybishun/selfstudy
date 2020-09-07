using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Module1.Models;

namespace Module1.Controllers
{
    [Produces("application/json")]
    [Route("api/Customers")]
    public class CustomersController : Controller
    {
        static List<Customer> _customers = new List<Customer>()
        {
            new Customer() { Id = 0, Name = "Ray", Email = "Ray@msft.com", Phone = "123" },
            new Customer() { Id = 1, Name = "Jessica", Email = "jessica@msft.com", Phone = "456" }
        };

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customers;
        }

        [HttpPost]
        public IActionResult Post([FromBody]Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customers.Add(customer);
                return Ok();
            }

            return BadRequest(ModelState);



            /* Postman POST test (using invalid data):
             http://localhost:54454/api/Customers

            {
	            "Id": 2,
	            "Name": "Jennifer",
	            "Email": "123",
	            "Phone": "yyy"
            }
             */
        }
    }
}