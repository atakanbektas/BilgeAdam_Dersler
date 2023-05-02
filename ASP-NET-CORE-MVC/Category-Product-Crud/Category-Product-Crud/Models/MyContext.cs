using Microsoft.EntityFrameworkCore;

namespace Category_Product_Crud.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AddDummyData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private void AddDummyData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category("Phone") { CategoryId = 1 },
                new Category("Computer") { CategoryId = 2 },
                new Category("Television") { CategoryId = 3 }
                );
            modelBuilder.Entity<Product>().HasData(
 new Product() { ProductId = 1, Name = "Hp", Price = 30000, InStock = true, CategoryId = 2 },
 new Product() { ProductId = 2, Name = "MacBook", Price = 50000, InStock = true, CategoryId = 2 },
 new Product() { ProductId = 3, Name = "Apple", Price = 20000, InStock = true, CategoryId = 1 },
 new Product() { ProductId = 4, Name = "Xiaomi", Price = 12000, InStock = true, CategoryId = 1 },
 new Product() { ProductId = 5, Name = "Samsung", Price = 27500, InStock = true, CategoryId = 3 },
 new Product() { ProductId = 6, Name = "Vestel", Price = 32700, InStock = true, CategoryId = 3 }
 );

        }
    }
}
