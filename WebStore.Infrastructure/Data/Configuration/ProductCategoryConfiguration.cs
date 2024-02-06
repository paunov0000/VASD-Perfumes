using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Infrastructure.Data.Entities;
using static WebStore.Infrastructure.Data.Constants.ConfigurationConstants.ProductCategory;

namespace WebStore.Infrastructure.Data.Configuration
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasData(CreateProductCategories());
        }

        private List<ProductCategory> CreateProductCategories()
        {
            return new List<ProductCategory>()
            {
                new ProductCategory
                {
                    Id = Guid.Parse(FloralId),
                    Name = "Floral",
                    Description = "Floral scents are the most popular and widely used perfume family. Floral perfumes are feminine, romantic, and ultra-feminine.",
                },
                new ProductCategory
                {
                    Id = Guid.Parse(OrientalId),
                    Name = "Oriental",
                    Description = "Oriental perfumes are warm, sensual, and exotic. They are often described as spicy, sweet, and even opulent.",
                },
                new ProductCategory
                {
                    Id = Guid.Parse(FreshId),
                    Name = "Fresh",
                    Description = "Fresh perfumes are often referred to as citrus or green. They are light, airy, and clean.",
                },
                new ProductCategory
                {
                    Id = Guid.Parse(WoodyId),
                    Name = "Woody",
                    Description = "Woody perfumes are warm, earthy, and sensual. They are often described as musky, aromatic, and spicy.",
                }
            };
        }
    }
}
