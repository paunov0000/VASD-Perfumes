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
    public class SubcategoryConfiguration : IEntityTypeConfiguration<Subcategory>
    {
        public void Configure(EntityTypeBuilder<Subcategory> builder)
        {
            builder.HasData(CreateSubcategories());
        }

        private List<Subcategory> CreateSubcategories()
        {
            var result = new List<Subcategory>();

            var subcategory = new Subcategory
            {
                Id = Guid.Parse("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b"),
                Name = "Man",
                CategoryId = Guid.Parse("53146915-6199-44EB-AEDB-E9902299BE6C")
            };

            result.Add(subcategory);

            subcategory = new Subcategory
            {
                Id = Guid.Parse("98c91d15-4a4c-4fc4-b226-f9835e1560d2"),
                Name = "Woman",
                CategoryId = Guid.Parse("53146915-6199-44EB-AEDB-E9902299BE6C")
            };

            result.Add(subcategory);

            subcategory = new Subcategory
            {
                Id = Guid.Parse("45c73d43-2499-422e-a5b5-5f0086331e51"),
                Name = "Unisex",
                CategoryId = Guid.Parse("53146915-6199-44EB-AEDB-E9902299BE6C")
            };

            result.Add(subcategory);

            return result;
        }
    }
}
