using Microsoft.EntityFrameworkCore;
using Module1.Models;

namespace Module1.Data
{
    public class ProductsDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
