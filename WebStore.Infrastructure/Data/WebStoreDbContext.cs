using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebStore.Infrastructure.Data.Configuration;
using WebStore.Infrastructure.Data.Entities;

namespace WebStore.Infrastructure.Data
{
    public class WebStoreDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public WebStoreDbContext(DbContextOptions<WebStoreDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<Order> Orders { get; set; }

        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<OrderStatus> OrderStatuses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new ProductCategoryConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());


            base.OnModelCreating(builder);
        }


    }
}
