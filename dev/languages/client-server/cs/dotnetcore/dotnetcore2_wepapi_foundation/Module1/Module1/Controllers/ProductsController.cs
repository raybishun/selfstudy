using System.Collections.Generic;
using System.Linq;
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
            var product = productsDbContext.Products.SingleOrDefault(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound("Record not found...");
            }

            return Ok(product);
        }
        
        // POST: api/Products
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Products/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
