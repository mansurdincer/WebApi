namespace WebApi.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Kırtasiye" },
                new Category { Id = 2, Name = "Elektronik" },
                new Category { Id = 3, Name = "Giyim" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Kitap", CategoryId = 1 },
                new Product { Id = 2, Name = "Defter", CategoryId = 1 },
                new Product { Id = 3, Name = "Bilgisayar", CategoryId = 2 },
                new Product { Id = 4, Name = "Tablet", CategoryId = 2 },
                new Product { Id = 5, Name = "Pantolon", CategoryId = 3 },
                new Product { Id = 6, Name = "Etek", CategoryId = 3 }
            );
        }
    }
}
