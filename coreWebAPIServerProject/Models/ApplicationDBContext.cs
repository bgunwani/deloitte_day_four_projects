using Microsoft.EntityFrameworkCore;

namespace coreWebAPIServerProject.Models
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 101,
                    ProductName = "Keyboard",
                    ProductPrice = 2000,
                    ProductQuantity = 10
                },
                    new Product()
                    {
                        ProductId = 102,
                        ProductName = "Mouse",
                        ProductPrice = 1500,
                        ProductQuantity = 20
                    },
                    new Product()
                    {
                        ProductId = 103,
                        ProductName = "HardDisk",
                        ProductPrice = 3500,
                        ProductQuantity = 10
                    },
                    new Product()
                    {
                        ProductId = 104,
                        ProductName = "Sanner",
                        ProductPrice = 4000,
                        ProductQuantity = 5
                    }
                );
        }
    }
}
