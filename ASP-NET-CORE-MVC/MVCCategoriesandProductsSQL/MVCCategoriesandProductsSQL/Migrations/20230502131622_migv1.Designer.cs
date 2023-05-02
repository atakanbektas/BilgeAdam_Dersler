﻿// <auto-generated />
using MVCCategoriesandProductsSQL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCCategoriesandProductsSQL.Migrations
{
    [DbContext(typeof(ProductsContext))]
    [Migration("20230502131622_migv1")]
    partial class migv1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MVCCategoriesandProductsSQL.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Phone"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Computer"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Television"
                        });
                });

            modelBuilder.Entity("MVCCategoriesandProductsSQL.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            IsInStock = true,
                            Name = "Hp",
                            Price = 30000m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            IsInStock = true,
                            Name = "MacBook",
                            Price = 50000m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            IsInStock = true,
                            Name = "Apple",
                            Price = 20000m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            IsInStock = true,
                            Name = "Xiaomi",
                            Price = 12000m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            IsInStock = true,
                            Name = "Samsung",
                            Price = 27500m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            IsInStock = true,
                            Name = "Vestel",
                            Price = 32700m
                        });
                });

            modelBuilder.Entity("MVCCategoriesandProductsSQL.Models.Product", b =>
                {
                    b.HasOne("MVCCategoriesandProductsSQL.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MVCCategoriesandProductsSQL.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
