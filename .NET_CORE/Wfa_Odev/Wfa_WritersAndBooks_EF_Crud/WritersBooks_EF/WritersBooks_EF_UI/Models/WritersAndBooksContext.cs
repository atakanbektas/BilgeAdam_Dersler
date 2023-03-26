using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WritersBooks_EF_UI.Models
{
    public partial class WritersAndBooksContext : DbContext
    {
        public WritersAndBooksContext()
        {
        }

        public WritersAndBooksContext(DbContextOptions<WritersAndBooksContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Writer> Writers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=WritersAndBooks;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.BookName).HasMaxLength(70);

                entity.Property(e => e.Description).HasMaxLength(1000);
            });

            modelBuilder.Entity<Writer>(entity =>
            {
                entity.Property(e => e.FirstName).HasMaxLength(35);

                entity.Property(e => e.LastName).HasMaxLength(25);

                entity.HasMany(d => d.Books)
                    .WithMany(p => p.Writers)
                    .UsingEntity<Dictionary<string, object>>(
                        "BooksWriter",
                        l => l.HasOne<Book>().WithMany().HasForeignKey("BookId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_BooksWriters_Books"),
                        r => r.HasOne<Writer>().WithMany().HasForeignKey("WriterId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_BooksWriters_Writers"),
                        j =>
                        {
                            j.HasKey("WriterId", "BookId");

                            j.ToTable("BooksWriters");
                        });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
