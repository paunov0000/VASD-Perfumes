using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Infrastructure.Data.Entities;

namespace WebStore.Infrastructure.Data.Configuration
{
    public class ParentSubcategoryConfiguration : IEntityTypeConfiguration<ParentSubcategory>
    {
        public void Configure(EntityTypeBuilder<ParentSubcategory> builder)
        {
            builder.HasData(CreateSubcategories());
        }

        private List<ParentSubcategory> CreateSubcategories()
        {
            var result = new List<ParentSubcategory>();

            var subcategory = new ParentSubcategory
            {
                Id = Guid.Parse("5f1efcf7-0a16-4079-ae7f-aebbd4f5ca3b"),
                Name = "Men",
                CategoryId = Guid.Parse("53146915-6199-44EB-AEDB-E9902299BE6C")
            };

            result.Add(subcategory);

            subcategory = new ParentSubcategory
            {
                Id = Guid.Parse("98c91d15-4a4c-4fc4-b226-f9835e1560d2"),
                Name = "Women",
                CategoryId = Guid.Parse("53146915-6199-44EB-AEDB-E9902299BE6C")
            };

            result.Add(subcategory);

            subcategory = new ParentSubcategory
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
