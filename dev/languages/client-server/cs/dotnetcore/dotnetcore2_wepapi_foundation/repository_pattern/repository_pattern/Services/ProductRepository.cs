using System.Collections.Generic;
using System.Linq;
using repository_pattern.Data;
using repository_pattern.Models;

namespace repository_pattern.Services
{
    public class ProductRepository : IProduct
    {
        private ProductsDbContext productsDbContext;

        public ProductRepository(ProductsDbContext _productsDbContext)
        {
            productsDbContext = _productsDbContext;
        }

        public IEnumerable<Product> GetProducts()
        {
            return productsDbContext.Products;
        }

        public Product GetProduct(int id)
        {
            var product = productsDbContext.Products.SingleOrDefault(p => p.ProductId == id);

            return product;
        }

        public void AddProduct(Product product)
        {
            productsDbContext.Products.Add(product);
            productsDbContext.SaveChanges(true);
        }

        public void UpdateProduct(Product product)
        {
            productsDbContext.Products.Update(product);
            productsDbContext.SaveChanges(true);
        }
        
        public void DeleteProduct(int id)
        {
            //var product = productsDbContext.Products.SingleOrDefault(p => p.ProductId == id);
            //if (product != null) productsDbContext.Products.Remove(product);
            //productsDbContext.SaveChanges(true);

            // NOTE: Using Find() below so now don't need the null check as required above
            var product = productsDbContext.Products.Find(id);
            productsDbContext.Products.Remove(product);
            productsDbContext.SaveChanges(true);
        }
    }
}
