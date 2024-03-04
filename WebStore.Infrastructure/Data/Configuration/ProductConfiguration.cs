using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Infrastructure.Data.Entities;
using static WebStore.Infrastructure.Data.Constants.ConfigurationConstants.Product;
using static WebStore.Infrastructure.Data.Constants.ConfigurationConstants.ProductCategory;

namespace WebStore.Infrastructure.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p=> p.IsActive)
                .HasDefaultValue(true);

            builder.HasData(CreateProducts());
        }

        public List<Product> CreateProducts()
        {
            return new List<Product>()
            {
                new Product
                {
                    Id = Guid.Parse(Chanel05Id),
                    Name = "Chanel No. 5",
                    Description = "Iconic blend of rose and jasmine, a classic from luxury brand Chanel",
                    Manufacturer = "Chanel",
                    Price = 120.00M,
                    ImageUrl ="https://www.sephora.com/productimages/sku/s465690-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    ProductCategoryId = Guid.Parse(FloralId)
                },
                new Product
                {
                    Id = Guid.Parse(MarcJacobsDaisyId),
                    Name = "Marc Jacobs Daisy",
                    Description = "Youthful and fresh floral scent with notes of jasmine and violet",
                    Manufacturer = "Marc Jacobs",
                    Price = 80.00M,
                    ImageUrl = "https://www.sephora.com/productimages/sku/s1029958-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    ProductCategoryId = Guid.Parse(FloralId)
                },
                new Product
                {
                    Id = Guid.Parse(GucciBloomId),
                    Name = "Gucci Bloom",
                    Description = "Modern and vibrant floral bouquet featuring tuberose and jasmine",
                    Manufacturer = "Gucci",
                    Price = 150.00M,
                    ImageUrl = "https://www.sephora.com/productimages/sku/s1964832-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    ProductCategoryId = Guid.Parse(FloralId)
                },
                new Product
                {
                    Id = Guid.Parse(ViktorRolfFlowerbombId),
                    Name = "Viktor&Rolf Flowerbomb",
                    Description = "Intensely floral with notes of jasmine, rose, and orchid",
                    Manufacturer = "Viktor&Rolf",
                    Price = 110.00M,
                    ImageUrl = "https://www.sephora.com/productimages/sku/s1377159-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    ProductCategoryId = Guid.Parse(FloralId)
                },
                new Product
                {
                    Id = Guid.Parse(ShalimarByGuerlainId),
                    Name = "Shalimar by Guerlain",
                    Description = "Timeless oriental scent with vanilla, iris, and amber notes",
                    Manufacturer = "Guerlain",
                    Price = 140.00M,
                    ImageUrl = "https://douglas.bg/media/catalog/product/cache/dd4850ad4231b6306bceadf38a0bbeed/1/_/1_4439.jpg",
                    CreatedOn = DateTime.UtcNow,
                    ProductCategoryId = Guid.Parse(OrientalId)
                },
                new Product
                {
                    Id = Guid.Parse(OpiumByYvesSaintLaurentId),
                    Name = "Opium by Yves Saint Laurent",
                    Description = "Rich and spicy oriental fragrance with exotic undertones",
                    Manufacturer = "Yves Saint Laurent",
                    Price = 100.00M,
                    ImageUrl = "https://www.yslbeautyus.com/dw/image/v2/AANG_PRD/on/demandware.static/-/Sites-ysl-master-catalog/default/dwfd20b6ef/Fragrance/Fragrance/Opium_Eau_De_Toilette_Spray/3365440556386_Opium-Eau-De-Tpilette-Spray_01.jpg?sw=698&sh=698&sm=cut&sfrm=jpg&q=85",
                    CreatedOn = DateTime.UtcNow,
                    ProductCategoryId = Guid.Parse(FreshId)
                },
                new Product
                {
                    Id = Guid.Parse(BlackOrchidByTomFordId),
                    Name = "Black Orchid by Tom Ford",
                    Description = "Luxurious blend of black truffle, vanilla, and orchid",
                    Manufacturer = "Tom Ford",
                    Price = 180.00M,
                    ImageUrl = "https://www.sephora.com/productimages/sku/s1007731-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    ProductCategoryId = Guid.Parse(FreshId)
                },
                new Product
                {
                    Id = Guid.Parse(AcquaDiGioByGiorgioArmaniId),
                    Name = "Acqua di Gio by Giorgio Armani",
                    Description = "Fresh and aquatic scent with notes of citrus and rosemary",
                    Manufacturer = "Giorgio Armani",
                    Price = 85.00M,
                    ImageUrl = "https://www.sephora.com/productimages/sku/s397299-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    ProductCategoryId = Guid.Parse(FreshId)
                },
                new Product
                {
                    Id = Guid.Parse(TerreDhermesByHermesId),
                    Name = "Terre d'Hermès by Hermès",
                    Description = "Citrusy and woody fragrance with notes of grapefruit and cedar",
                    Manufacturer = "Hermès",
                    Price = 120.00M,
                    ImageUrl = "https://www.sephora.com/productimages/sku/s915447-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    ProductCategoryId = Guid.Parse(WoodyId)
                },
                new Product
                {
                    Id = Guid.Parse(AventusByCreedId),
                    Name = "Aventus by Creed",
                    Description = "Fresh and fruity scent with notes of pineapple and blackcurrant",
                    Manufacturer = "Creed",
                    Price = 250.00M,
                    ImageUrl = "https://creedboutique.com/cdn/shop/files/aventus-100ml-bottle_3413e5f4-3eee-40b3-8451-2546a370ec5b.jpg?v=1700498936&width=1500",
                    CreatedOn = DateTime.UtcNow,
                    ProductCategoryId = Guid.Parse(WoodyId)
                }
            };
        }
    }
}

