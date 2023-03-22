using Microsoft.EntityFrameworkCore;
using RehberCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RehberCode.Context
{
    public class RehberContext : DbContext
    {
        public RehberContext()
        {

        }
        public RehberContext(DbContextOptions<RehberContext> options) : base(options)
        {

        }
        public virtual DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=RehberDB;User Id=sa;Password=sa;TrustServerCertificate=True;");

       
    }
}
