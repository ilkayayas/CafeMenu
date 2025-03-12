using CafeMenu.Data.Configurations;
using CafeMenu.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CafeMenu.Data
{
    public class CafeMenuDbContext : IdentityDbContext
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
