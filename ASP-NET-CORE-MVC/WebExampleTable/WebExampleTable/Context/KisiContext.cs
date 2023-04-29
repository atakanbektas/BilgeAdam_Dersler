using Microsoft.EntityFrameworkCore;
using WebExampleTable.Models;

namespace WebExampleTable.Context
{
    public class KisiContext : DbContext
    {
        public KisiContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Kisi> Kisiler { get; set; }
        public DbSet<Araba> Arabalar { get; set; }


    }
}
