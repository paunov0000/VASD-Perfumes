using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Infrastructure.Data.Entities;

namespace WebStore.Infrastructure.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            //builder
            //    .Property(p => p.EmailConfirmed)
            //    .HasDefaultValue(true);


            builder.HasData(CreateUsers());
        }

        public List<ApplicationUser> CreateUsers()
        {
            var users = new List<ApplicationUser>();
            var hasher = new PasswordHasher<ApplicationUser>();

            var user = new ApplicationUser
            {
                Id = Guid.Parse("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
                UserName = "bojkata@abv.bg",
                FirstName = "Bojidar",
                LastName = "Bojidarov",
                NormalizedUserName = "BOJKATA@ABV.BG",
                Email = "bojkata@abv.bg",
                NormalizedEmail = "BOJKATA@ABV.BG",
                EmailConfirmed = true,
                SecurityStamp = "675bdfac-f10f-4acc-a641-4233cd7a4c14",
            };

            user.PasswordHash = hasher.HashPassword(user, "test123");

            users.Add(user);

            user = new ApplicationUser
            {
                Id = Guid.Parse("753efde4-efa1-4f88-abc9-8f091cf8b670"),
                UserName = "admin@admin.bg",
                FirstName = "Admin",
                LastName = "Adminov",
                NormalizedUserName = "ADMIN@ADMIN.BG",
                Email = "admin@admin.bg",
                NormalizedEmail = "ADMIN@ADMIN.BG",
                EmailConfirmed = true,
                SecurityStamp = "efcff289-5cd2-42eb-8280-5faaab34daf5",
            };

            user.PasswordHash = hasher.HashPassword(user, "admin123");

            users.Add(user);

            return users;


        }

    }
}
