using repository_pattern.Models;
using System.Collections.Generic;

namespace repository_pattern.Services
{
    public interface IProduct
    {
        IEnumerable<Product> GetProducts();

        Product GetProduct(int id);

        void AddProduct(Product product);

        void UpdateProduct(Product product);

        void DeleteProduct(int id);
    }
}
