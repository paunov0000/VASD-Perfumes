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
    public class RoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.HasData(CreateRoles());
        }

        private List<ApplicationRole> CreateRoles()
        {
            var roles = new List<ApplicationRole>();

            var role = new ApplicationRole
            {
                Id = Guid.Parse("8027c9ed-85ce-4837-bf14-3ed6152e35ad"),
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR",
                ConcurrencyStamp = "93a8d9e6-3e85-4e80-841f-8d0a502a5bea",
            };

            roles.Add(role);

            role = new ApplicationRole
            {
                Id = Guid.Parse("44e92506-a5bd-494a-b749-7d90bdfe9628"),
                Name = "Customer",
                NormalizedName = "CUSTOMER",
                ConcurrencyStamp = "c675d451-7dec-4e15-8933-76e1348cdc20"
            };

            roles.Add(role);

            role = new ApplicationRole
            {
                Id = Guid.Parse("85805833-8f47-4355-bd15-9465a8a65c07"),
                Name = "Vip",
                NormalizedName = "VIP",
                ConcurrencyStamp = "cccc29af-0d53-4faa-ba1e-b08218c7b14b"
            };

            roles.Add(role);

            //role = new ApplicationRole
            //{
            //    Id = Guid.Parse("82546160-02c3-4485-b7e2-cd20797402fe"),
            //    Name = "User",
            //    NormalizedName = "USER",
            //    ConcurrencyStamp = "482925f6-6843-4718-b4af-ebab32b6ec0a",
            //};

            //roles.Add(role);

            return roles;
        }
    }
}
