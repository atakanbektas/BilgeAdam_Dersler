using ETicaretApp.Domain.Entities;
using ETicaretApp.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ETicaretApp.Percistence.Context
{
    public class ETicarettAppDBContext : DbContext
    {
        public ETicarettAppDBContext()
        {

        }
        public ETicarettAppDBContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseSqlServer(Settings.ConnString);













    }
}
