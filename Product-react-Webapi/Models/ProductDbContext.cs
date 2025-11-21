using Microsoft.EntityFrameworkCore;

namespace Product_react_Webapi.Models
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }
        public DbSet<Products> Products { get; set; }
    }
}
