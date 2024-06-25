using Microsoft.EntityFrameworkCore;
using ProductListAPI.Models;

namespace ProductListAPI.Data
{
    public class ProductListAPIDbContext : DbContext
    {
        public ProductListAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
