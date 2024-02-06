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
                UserName = "bojkata",
                NormalizedUserName = "BOJKATA",
                Email = "bojkata@abv.bg",
                NormalizedEmail = "BOJKATA@ABV.BG",
                EmailConfirmed = true
            };

            user.PasswordHash = hasher.HashPassword(user, "test123");

            users.Add(user);

            return users;


        }

    }
}
