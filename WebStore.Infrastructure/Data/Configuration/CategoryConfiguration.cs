using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Infrastructure.Data.Entities;
using static WebStore.Infrastructure.Data.Constants.ConfigurationConstants.Category;

namespace WebStore.Infrastructure.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CreateCategories());
        }

        private List<Category> CreateCategories()
        {
            return new List<Category>()
            {
                new Category
                {
                    Id = Guid.Parse(FragranceId),
                    Name = "Fragrance",
                },
                //new Category
                //{
                //    Id = Guid.Parse(OrientalId),
                //    Name = "Oriental",
                //},
                //new Category
                //{
                //    Id = Guid.Parse(FreshId),
                //    Name = "Fresh",
                //},
                //new Category
                //{
                //    Id = Guid.Parse(WoodyId),
                //    Name = "Woody",
                //}
            };
        }
    }
}
