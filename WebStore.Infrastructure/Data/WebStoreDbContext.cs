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

        public DbSet<Category> Categories { get; set; }

        public DbSet<ParentSubcategory> ParentSubcategories { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<OrderStatus> OrderStatuses { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<ChildSubcategory> ChildSubcategories { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Product>()
            //    .HasOne(p=>p.ParentSubcategory)
            //    .WithMany(psc=>psc.Products)
            //    .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<ParentSubcategory>()
                .HasMany(psc => psc.ChildSubcategories)
                .WithMany(csc => csc.ParentSubcategories);

            builder.ApplyConfiguration(new BrandConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new CustomerConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new ParentSubcategoryConfiguration());
            builder.ApplyConfiguration(new OrderStatusConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());

            base.OnModelCreating(builder);
        }


    }
}
