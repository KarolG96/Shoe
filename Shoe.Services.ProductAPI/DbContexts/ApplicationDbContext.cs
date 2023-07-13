using Microsoft.EntityFrameworkCore;
using Shoe.Services.ProductAPI.Models;

namespace Shoe.Services.ProductAPI.DbContexts
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
        public DbSet<Product> Products { get; set; }

    }
}
