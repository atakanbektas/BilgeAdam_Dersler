using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace UserLoginDBFirst.Models;

public partial class KullaniciDbContext : DbContext
{
    public KullaniciDbContext()
    {
    }

    public KullaniciDbContext(DbContextOptions<KullaniciDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Human> Humans { get; set; }

    public virtual DbSet<Profile> Profiles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=KullaniciDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Human>(entity =>
        {
            entity.HasIndex(e => e.HumanId, "IX_Humans").IsUnique();

            entity.Property(e => e.HumanId).HasColumnName("HumanID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Surname).HasMaxLength(50);
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.Property(e => e.ProfileId)
                .HasMaxLength(50)
                .HasColumnName("ProfileID");
            entity.Property(e => e.HumanId).HasColumnName("HumanID");
            entity.Property(e => e.Password).HasMaxLength(50);

            entity.HasOne(d => d.Human).WithMany(p => p.Profiles)
                .HasForeignKey(d => d.HumanId)
                .HasConstraintName("FK_Profiles_Humans");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
