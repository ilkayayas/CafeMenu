using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CafeMenu.Data.Entities;

namespace CafeMenu.Data.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(g => g.CategoryId);

            // Configure properties
            builder.Property(g => g.CategoryName).IsRequired().HasMaxLength(100);
            builder.Property(g => g.ParentCategoryId).IsRequired();
            builder.Property(g => g.IsDeleted).IsRequired();
            builder.Property(g => g.CreatedDate).IsRequired();
            builder.Property(g => g.CreatorUserId).IsRequired();

            builder.HasData(
                
            new Category {
                CategoryId = 1,
                CategoryName = "Kategori 1", 
                ParentCategoryId = 0, 
                IsDeleted = false, 
                CreatedDate = new DateTime(2025, 3, 11, 23, 54, 10, 460, DateTimeKind.Local), 
                CreatorUserId = 1 },
            new Category
            {
                CategoryId = 2,
                CategoryName = "Kategori 2",
                ParentCategoryId = 0,
                IsDeleted = false,
                CreatedDate = new DateTime(2025, 3, 11, 23, 54, 10, 460, DateTimeKind.Local),
                CreatorUserId = 1
            },
             new Category
            {
                CategoryId = 3,
                CategoryName = "Kategori 1-1",
                ParentCategoryId = 1,
                IsDeleted = false,
                CreatedDate = new DateTime(2025, 3, 11, 23, 54, 10, 460, DateTimeKind.Local),
                CreatorUserId = 1
            },
            new Category
            {
                CategoryId = 4,
                CategoryName = "Kategori 1-2",
                ParentCategoryId = 1,
                IsDeleted = false,
                CreatedDate = new DateTime(2025, 3, 11, 23, 54, 10, 460, DateTimeKind.Local),
                CreatorUserId = 1
            }, 
            new Category
            {
                CategoryId = 5,
                CategoryName = "Kategori 1-1-1",
                ParentCategoryId = 3,
                IsDeleted = false,
                CreatedDate = new DateTime(2025, 3, 11, 23, 54, 10, 460, DateTimeKind.Local),
                CreatorUserId = 1
            },
            new Category
            {
                CategoryId = 6,
                CategoryName = "Kategori 1-1-2",
                ParentCategoryId = 3,
                IsDeleted = true,
                CreatedDate = new DateTime(2025, 3, 11, 23, 54, 10, 460, DateTimeKind.Local),
                CreatorUserId = 1
            }


            );

        }
    }
}
