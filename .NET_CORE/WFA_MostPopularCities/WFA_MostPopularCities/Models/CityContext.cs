using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_MostPopularCities.Models
{
    public class CityContext : DbContext
    {
        public CityContext()
        {

        }
        public CityContext(DbContextOptions<CityContext> options) : base(options)
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=CityDB;TrustServerCertificate=True;Trusted_Connection=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.HasIndex(e => e.Name, "CityName");
                entity.Property(e => e.Name).HasMaxLength(25);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.Name, "ProductName");
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            AddDummyData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
        private void AddDummyData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City() { CityId = 1, Name = "Adana" },
                new City() { CityId = 6, Name = "Ankara" },
                new City() { CityId = 61, Name = "Trabzon" }
                );

            modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, Name = "Keçi", CityId = 6 },
            new Product { ProductId = 2, Name = "Şırdan", CityId = 1 },
            new Product { ProductId = 3, Name = "Aykut Bey", CityId = 1},
            new Product { ProductId = 4, Name = "Tereyağ", CityId = 61},
            new Product { ProductId = 5, Name = "Ekmek", CityId = 61}
            );
        }

    }
}
