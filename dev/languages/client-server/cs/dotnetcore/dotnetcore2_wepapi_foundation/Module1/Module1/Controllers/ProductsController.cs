using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module1.Models;

namespace Module1.Controllers
{
    [Produces("application/json")]
    [Route("api/Products")]
    public class ProductsController : Controller
    {
        static List<Product> _products = new List<Product>()
        {
            new Product() {ProductId = 0, ProductName = "Laptop", ProductPrice = "200" },
            new Product() {ProductId = 1, ProductName = "SmartPhone", ProductPrice = "100" }
        };

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _products;
        }

        [HttpPost]
        public void Post([FromBody]Product product)
        {
            _products.Add(product);


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
 