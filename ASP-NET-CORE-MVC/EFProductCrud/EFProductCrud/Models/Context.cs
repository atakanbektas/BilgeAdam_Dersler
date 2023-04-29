using Microsoft.EntityFrameworkCore;

namespace EFProductCrud.Models
{
    public class Context : DbContext
    {
        public Context()
        {

        }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public virtual DbSet<Product> Products { get; set; }



    }
}
