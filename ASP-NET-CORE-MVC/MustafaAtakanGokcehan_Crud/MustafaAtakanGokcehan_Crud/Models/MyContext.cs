using Microsoft.EntityFrameworkCore;

namespace MustafaAtakanGokcehan_Crud.Models
{
    public class MyContext : DbContext
    {
        public MyContext()
        {

        }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Branch> Branches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
