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
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasData(CreateUserRoles());
        }

        private List<IdentityUserRole<Guid>> CreateUserRoles()
        {
            var userRoles = new List<IdentityUserRole<Guid>>();

            var userRole = new IdentityUserRole<Guid>
            {
                UserId = Guid.Parse("753EFDE4-EFA1-4F88-ABC9-8F091CF8B670"),
                RoleId = Guid.Parse("8027C9ED-85CE-4837-BF14-3ED6152E35AD"),
            };

            userRoles.Add(userRole);

            return userRoles;
        }
    }
}
