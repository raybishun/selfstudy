using Microsoft.EntityFrameworkCore;
using webapi_basics.Models;

namespace webapi_basics.Data
{
    public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
