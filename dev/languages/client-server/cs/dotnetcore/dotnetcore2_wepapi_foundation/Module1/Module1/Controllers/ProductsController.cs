using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module1.Data;
using Module1.Models;

namespace Module1.Controllers
{
    [Produces("application/json")]
    [Route("api/Products")]
    public class ProductsController : Controller
    {
        ProductsDbContext productsDbContext;

        public ProductsController(ProductsDbContext _productDbContext)
        {
            productsDbContext = _productDbContext;
        }

        // GET: api/Products
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return productsDbContext.Products;
        }

        // GET: api/Products/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var product = productsDbContext.Products.SingleOrDefault(p => p.ProductId == id);

            if (product == null)
            {
                return NotFound($"{id} not found.");
            }

            return Ok(product);
        }
        
        // POST: api/Products
        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            
            productsDbContext.Products.Add(product);
            productsDbContext.SaveChanges(true);
            return StatusCode(StatusCodes.Status201Created);

            /* Postman test:

                Method: POST
                URL: http://localhost:54454/api/Products
                Body: raw\text\JSON

                { 
                    "ProductName": "Product1",
                    "ProductPrice": "500"
                }
            */
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product.ProductId)
            {
                return BadRequest();
            }

            try
            {
                productsDbContext.Products.Update(product);
                productsDbContext.SaveChanges(true);
 
                /* Postman test:

                   Method: PUT
                   URL: http://localhost:54454/api/Products/3
                   Body: raw\text\JSON

                   {
                        "productId": 3,
                        "productName": "Put test",
                        "productPrice": "800"
                    }
               */
            }
            catch (System.Exception)
            {
                return NotFound($"{id} not found.");
            }

            return Ok($"{id} updated.");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = productsDbContext.Products.SingleOrDefault(p => p.ProductId == id);

            if (product == null)
            {
                return NotFound($"{id} not found.");
            }

            productsDbContext.Products.Remove(product);
            productsDbContext.SaveChanges(true);
            return Ok($"{id} deleted.");

            /* Postman test:

                 Method: DELETE
                 URL: http://localhost:54454/api/Products/3
                 Body: raw\text\JSON

                 {
                      "productId": 3,
                      "productName": "Put test",
                      "productPrice": "800"
                  }
             */
        }
    }
}
