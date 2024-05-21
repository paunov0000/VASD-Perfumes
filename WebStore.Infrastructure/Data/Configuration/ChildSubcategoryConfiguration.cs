using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Infrastructure.Data.Entities;

namespace WebStore.Infrastructure.Data.Configuration
{
    public class ChildSubcategoryConfiguration : IEntityTypeConfiguration<ChildSubcategory>
    {
        public void Configure(EntityTypeBuilder<ChildSubcategory> builder)
        {
            builder.HasData(CreateChildSubcategories());
        }


        private static IEnumerable<ChildSubcategory> CreateChildSubcategories()
        {
            return new List<ChildSubcategory>()
            {
                new ChildSubcategory()
                {
                    Id = Guid.Parse("0eff9eb3-f46f-408b-bb68-561e136aef76"),
                    Name = "EDP",
                },
                new ChildSubcategory()
                {
                    Id = Guid.Parse("3716553d-4f92-4e15-a411-0ff574e459cc"),
                    Name = "EDT",
                },
                new ChildSubcategory()
                {
                    Id = Guid.Parse("142ed5a1-52dc-4b2c-86a8-4694b479540e"),
                    Name = "Parfum",
                    
                },
                new ChildSubcategory()
                {
                    Id= Guid.Parse("442951ae-8062-4b69-a2d2-e9ee52ab16d1"),
                    Name = "EDC",
                },
            };
        }
    }
}
