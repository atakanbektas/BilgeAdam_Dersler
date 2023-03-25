using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HomePage.Models
{
    public class FilmContext : DbContext
    {
        public FilmContext()
        {

        }
        public FilmContext(DbContextOptions<FilmContext> options) : base(options)
        {

        }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Kind> Kinds { get; set; }
        public virtual DbSet<FilmKind> FilmKinds { get; set; }
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer(@"Server=.\\SQLEXPRESS;Database=FilmDB;Trusted_Connection=True;TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Film>(film =>
            {
                film.Property(f => f.FilmName).HasMaxLength(50);
            });
            modelBuilder.Entity<Kind>(kind =>
            {
                kind.Property(k => k.KindName).HasMaxLength(50);
            });

            //AddDummyData(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        private void AddDummyData(ModelBuilder modelBuilder)
        {


            //modelBuilder.Entity<FilmKind>().HasKey(fk => fk.FilmId);
            //modelBuilder.Entity<FilmKind>().HasKey(fk => fk.KindId);

            modelBuilder.Entity<Film>().HasData(
               new Film() { FilmId = 1, FilmName = "V For Vendetta", Duration = 127, Rating = 8},
               new Film() { FilmId = 2, FilmName = "Babam ve Oğlum", Duration = 112, Rating = 9},
               new Film() { FilmId = 3, FilmName = "Hızlı ve Öfkeli", Duration = 143, Rating = 7}
                );

            modelBuilder.Entity<Kind>().HasData(
                new Kind() { KindId = 0, KindName = "Dram" },
                new Kind() { KindId = 1, KindName = "Komedi" }
                );

            modelBuilder.Entity<FilmKind>().HasData(
                new FilmKind { FilmId = 1, KindId = 0 },
                new FilmKind { FilmId = 1, KindId = 1 },
                new FilmKind { FilmId = 2, KindId = 0 },
                new FilmKind { FilmId = 2, KindId = 1 },
                new FilmKind { FilmId = 3, KindId = 0 }
                );
        }
    }
}
