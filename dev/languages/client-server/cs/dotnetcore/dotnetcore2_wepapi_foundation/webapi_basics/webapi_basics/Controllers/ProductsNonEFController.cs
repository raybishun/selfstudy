using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi_basics.Models;

namespace webapi_basics.Controllers
{
    // [Produces("application/json")]
    [Route("api/ProductsNonEFController")]
    public class ProductsNonEFController : Controller
    {
        static List<Product> _products = new List<Product>()
        {
            new Product() {ProductId = 0, ProductName = "Laptop", ProductPrice = "200" },
            new Product() {ProductId = 1, ProductName = "SmartPhone", ProductPrice = "100" }
        };

        [HttpGet]
        public IActionResult Get()
        {
            // IActionResult includes shortcuts for many HTTP status codes
            // ----------------------------------------------------------------

            // Return an HTTP 400 BadRequest status code
            //return BadRequest();

            // Return an HTTP 404 NotFound status code
            // return NotFound();

            // Return other HTTP status codes not included in IActionResult using the code
            // return StatusCode(200);

            // However, you can simply use the class
            // return StatusCode(StatusCodes.Status201Created);

            // Return an HTTP 200 OK response status code
             return Ok(_products);
        }

        // Custom Method Example
        [HttpGet("GetList")]
        public IEnumerable<Product> GetMyCustomMethod()
        {
            return _products;

            // To test, use: http://localhost:54454/api/Products/GetList
        }

        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            _products.Add(product);
            return StatusCode(StatusCodes.Status201Created);


            /* To test this POST method, from Postman:
            -------------------------------------------------------------------
            1. http://localhost:54454/api/Products
            2. Body
            3. Raw
            4. Text\JSON
            5. Paste the below into the Body

            {
                "productId": 2,
                "productName": "Microphone",
                "productPrice": "50"
            }
            -------------------------------------------------------------------
             */
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product product)
        {
            _products[id] = product;

            /* To test this PUT method, from Postman:
            -------------------------------------------------------------------
            1. http://localhost:54454/api/Products/1
            2. Body
            3. Raw
            4. Text\JSON
            5. Paste the below into the Body

            {
                "productId": 1,
                "productName": "Samsung Mobile",
                "productPrice": "300"
            }
            -------------------------------------------------------------------
             */
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _products.RemoveAt(id);

            /* To test this DELETE method, from Postman:
            -------------------------------------------------------------------
            1. http://localhost:54454/api/Products/1
             */
        }
    }
}
 