﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Data;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221010140157_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<int>("RolesId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("WebApi.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Author")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Editor")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = 0,
                            CreatedDate = new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1299),
                            Editor = 0,
                            IsActive = false,
                            IsDeleted = false,
                            Name = "Kırtasiye"
                        },
                        new
                        {
                            Id = 2,
                            Author = 0,
                            CreatedDate = new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1310),
                            Editor = 0,
                            IsActive = false,
                            IsDeleted = false,
                            Name = "Elektronik"
                        },
                        new
                        {
                            Id = 3,
                            Author = 0,
                            CreatedDate = new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1311),
                            Editor = 0,
                            IsActive = false,
                            IsDeleted = false,
                            Name = "Giyim"
                        });
                });

            modelBuilder.Entity("WebApi.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Author")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Editor")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = 0,
                            CategoryId = 1,
                            Cost = 0m,
                            CreatedDate = new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1404),
                            Editor = 0,
                            IsActive = false,
                            IsDeleted = false,
                            Name = "Kitap",
                            Price = 0,
                            Stock = 0
                        },
                        new
                        {
                            Id = 2,
                            Author = 0,
                            CategoryId = 1,
                            Cost = 0m,
                            CreatedDate = new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1406),
                            Editor = 0,
                            IsActive = false,
                            IsDeleted = false,
                            Name = "Defter",
                            Price = 0,
                            Stock = 0
                        },
                        new
                        {
                            Id = 3,
                            Author = 0,
                            CategoryId = 2,
                            Cost = 0m,
                            CreatedDate = new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1407),
                            Editor = 0,
                            IsActive = false,
                            IsDeleted = false,
                            Name = "Bilgisayar",
                            Price = 0,
                            Stock = 0
                        },
                        new
                        {
                            Id = 4,
                            Author = 0,
                            CategoryId = 2,
                            Cost = 0m,
                            CreatedDate = new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1407),
                            Editor = 0,
                            IsActive = false,
                            IsDeleted = false,
                            Name = "Tablet",
                            Price = 0,
                            Stock = 0
                        },
                        new
                        {
                            Id = 5,
                            Author = 0,
                            CategoryId = 3,
                            Cost = 0m,
                            CreatedDate = new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1408),
                            Editor = 0,
                            IsActive = false,
                            IsDeleted = false,
                            Name = "Pantolon",
                            Price = 0,
                            Stock = 0
                        },
                        new
                        {
                            Id = 6,
                            Author = 0,
                            CategoryId = 3,
                            Cost = 0m,
                            CreatedDate = new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1409),
                            Editor = 0,
                            IsActive = false,
                            IsDeleted = false,
                            Name = "Etek",
                            Price = 0,
                            Stock = 0
                        });
                });

            modelBuilder.Entity("WebApi.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Author")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Editor")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = 0,
                            CreatedDate = new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1442),
                            Editor = 0,
                            IsActive = false,
                            IsDeleted = false,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Author = 0,
                            CreatedDate = new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1442),
                            Editor = 0,
                            IsActive = false,
                            IsDeleted = false,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("WebApi.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Author")
                        .HasColumnType("int");

                    b.Property<bool>("Confirmation")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Editor")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = 0,
                            Confirmation = false,
                            CreatedDate = new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1426),
                            Editor = 0,
                            Email = "",
                            IsActive = false,
                            IsDeleted = false,
                            Password = "1",
                            RoleId = 0,
                            Username = "Mansur"
                        },
                        new
                        {
                            Id = 2,
                            Author = 0,
                            Confirmation = false,
                            CreatedDate = new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1427),
                            Editor = 0,
                            Email = "",
                            IsActive = false,
                            IsDeleted = false,
                            Password = "1",
                            RoleId = 0,
                            Username = "Dondu"
                        });
                });

            modelBuilder.Entity("WebApi.Entities.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("Author")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Editor")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1,
                            Author = 0,
                            CreatedDate = new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1455),
                            Editor = 0,
                            Id = 0,
                            IsActive = false,
                            IsDeleted = false
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 2,
                            Author = 0,
                            CreatedDate = new DateTime(2022, 10, 10, 17, 1, 56, 781, DateTimeKind.Local).AddTicks(1456),
                            Editor = 0,
                            Id = 0,
                            IsActive = false,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("WebApi.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApi.Entities.Product", b =>
                {
                    b.HasOne("WebApi.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WebApi.Entities.UserRole", b =>
                {
                    b.HasOne("WebApi.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApi.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApi.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
