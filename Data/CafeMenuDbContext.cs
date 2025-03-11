using CafeMenu.Data.Configurations;
using CafeMenu.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CafeMenu.Data
{
    public class CafeMenuDbContext : DbContext
    {
        public CafeMenuDbContext(DbContextOptions<CafeMenuDbContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Category> Categories { get; set; }

        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CategoryConfiguration());
        }
    }

}
