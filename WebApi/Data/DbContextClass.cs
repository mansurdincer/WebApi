using Microsoft.EntityFrameworkCore;
using WebApi.Models;
using WebApi.DataTransferObjects;

namespace WebApi.Data
{
    public class DbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<WebApi.DataTransferObjects.CategoryDTO>? CategoryDTO { get; set; }
    }
}
