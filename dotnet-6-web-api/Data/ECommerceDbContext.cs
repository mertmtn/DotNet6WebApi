using dotnet_6_web_api.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_6_web_api.Data
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                                        .HasMany(c => c.Products)
                                        .WithOne(a => a.Category)
                                        .HasForeignKey(a => a.CategoryId);
            modelBuilder.Seed();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
