﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Data;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DbContextClassModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApi.Models.Category", b =>
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
                            Name = "Kırtasiye"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Elektronik"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Giyim"
                        });
                });

            modelBuilder.Entity("WebApi.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Cost = 0m,
                            Name = "Kitap",
                            Price = 0,
                            Stock = 0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Cost = 0m,
                            Name = "Defter",
                            Price = 0,
                            Stock = 0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Cost = 0m,
                            Name = "Bilgisayar",
                            Price = 0,
                            Stock = 0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Cost = 0m,
                            Name = "Tablet",
                            Price = 0,
                            Stock = 0
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            Cost = 0m,
                            Name = "Pantolon",
                            Price = 0,
                            Stock = 0
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Cost = 0m,
                            Name = "Etek",
                            Price = 0,
                            Stock = 0
                        });
                });

            modelBuilder.Entity("WebApi.Models.Product", b =>
                {
                    b.HasOne("WebApi.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebApi.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
