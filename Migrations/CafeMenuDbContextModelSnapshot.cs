﻿// <auto-generated />
using System;
using CafeMenu.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CafeMenu.Migrations
{
    [DbContext(typeof(CafeMenuDbContext))]
    partial class CafeMenuDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CafeMenu.Data.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatorUserId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ParentCategoryId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Kategori 1",
                            CreatedDate = new DateTime(2025, 3, 11, 23, 54, 10, 460, DateTimeKind.Local),
                            CreatorUserId = 1,
                            IsDeleted = false,
                            ParentCategoryId = 0
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Kategori 2",
                            CreatedDate = new DateTime(2025, 3, 11, 23, 54, 10, 460, DateTimeKind.Local),
                            CreatorUserId = 1,
                            IsDeleted = false,
                            ParentCategoryId = 0
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Kategori 1-1",
                            CreatedDate = new DateTime(2025, 3, 11, 23, 54, 10, 460, DateTimeKind.Local),
                            CreatorUserId = 1,
                            IsDeleted = false,
                            ParentCategoryId = 1
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Kategori 1-2",
                            CreatedDate = new DateTime(2025, 3, 11, 23, 54, 10, 460, DateTimeKind.Local),
                            CreatorUserId = 1,
                            IsDeleted = false,
                            ParentCategoryId = 1
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Kategori 1-1-1",
                            CreatedDate = new DateTime(2025, 3, 11, 23, 54, 10, 460, DateTimeKind.Local),
                            CreatorUserId = 1,
                            IsDeleted = false,
                            ParentCategoryId = 3
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Kategori 1-1-2",
                            CreatedDate = new DateTime(2025, 3, 11, 23, 54, 10, 460, DateTimeKind.Local),
                            CreatorUserId = 1,
                            IsDeleted = true,
                            ParentCategoryId = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
