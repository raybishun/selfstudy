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

        [HttpGet("GetUsingSearch")]
        public IEnumerable<Product> Get_Using_Search(string value)
        {
            var products = productsDbContext.Products.Where(p => p.ProductName.StartsWith(value));
            return products;

            /* Postman test:

                Method: GET
                http://localhost:54454/api/Products/GetUsingSearch?value=Android
            */
        }

        // GET: api/Products
        [HttpGet("GetSortedProducts")]
        public IEnumerable<Product> Get_Sorted_Products(string value)
        {
            // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            // NOTE:
            // IEnumerable will return 'all' results to the client
            // IQueryable will return only the filtered results
            // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            IQueryable<Product> products;

            switch (value)
            {
                case "desc":
                    products = productsDbContext.Products.OrderByDescending(p => p.ProductPrice);
                    break;
                case "asc":
                    products = productsDbContext.Products.OrderBy(p => p.ProductPrice);
                    break;
                default:
                    products = productsDbContext.Products;
                    break;
            }

            return products;

            /* Postman test:

                Method: GET
                http://localhost:54454/api/Products/GetSortedProducts/?value=desc
                http://localhost:54454/api/Products/GetSortedProducts/?value=asc
            */
        }

        [HttpGet("GetUsingPaging")]
        public IEnumerable<Product> Get_Using_Paging(int? pageNumber, int? pageSize)
        {
            var products = from p in productsDbContext.Products.OrderBy(a => a.ProductId) select p;

            int currentPage = pageNumber ?? 1;
            int currentPageSize = pageSize ?? 5;

            var items = products.Skip((currentPage - 1) * currentPageSize).Take(currentPageSize).ToList();

            return items;

            /* Postman test:

                Method: GET
                http://localhost:54454/api/Products/GetUsingPaging?pageNumber=1&pageSize=3
                http://localhost:54454/api/Products/GetUsingPaging?pageNumber=&pageSize=
             */
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
