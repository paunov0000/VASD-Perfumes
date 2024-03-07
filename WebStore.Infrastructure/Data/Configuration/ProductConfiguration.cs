using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Infrastructure.Data.Entities;
using static WebStore.Infrastructure.Data.Constants.ConfigurationConstants.Product;
using static WebStore.Infrastructure.Data.Constants.ConfigurationConstants.Category;
using static WebStore.Infrastructure.Data.Constants.ConfigurationConstants.Brand;

namespace WebStore.Infrastructure.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .Property(p => p.IsActive)
                .HasDefaultValue(true);

            builder
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            builder.HasData(CreateProducts());
        }

        public List<Product> CreateProducts()
        {
            return new List<Product>()
            {
                new Product
                {
                    Id = Guid.Parse(Chanel05Id),
                    Name = "No. 5",
                    Description = "Iconic blend of rose and jasmine, a classic from luxury brand Chanel",
                    Price = 120.00M,
                    ImageUrl ="https://www.sephora.com/productimages/sku/s465690-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    CategoryId = Guid.Parse(FragranceId),
                    BrandId = Guid.Parse(ChanelId)
                },
                new Product
                {
                    Id = Guid.Parse(MarcJacobsDaisyId),
                    Name = "Daisy",
                    Description = "Youthful and fresh floral scent with notes of jasmine and violet",
                    Price = 80.00M,
                    ImageUrl = "https://www.sephora.com/productimages/sku/s1029958-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    CategoryId = Guid.Parse(FragranceId),
                    BrandId = Guid.Parse(MarcJacobsId)
                },
                new Product
                {
                    Id = Guid.Parse(GucciBloomId),
                    Name = "Bloom",
                    Description = "Modern and vibrant floral bouquet featuring tuberose and jasmine",
                    Price = 150.00M,
                    ImageUrl = "https://www.sephora.com/productimages/sku/s1964832-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    CategoryId = Guid.Parse(FragranceId),
                    BrandId = Guid.Parse(GucciId)
                },
                new Product
                {
                    Id = Guid.Parse(ViktorRolfFlowerbombId),
                    Name = "Flowerbomb",
                    Description = "Intensely floral with notes of jasmine, rose, and orchid",
                    Price = 110.00M,
                    ImageUrl = "https://www.sephora.com/productimages/sku/s1377159-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    CategoryId = Guid.Parse(FragranceId),
                    BrandId = Guid.Parse(ViktorRolfId)
                },
                new Product
                {
                    Id = Guid.Parse(ShalimarByGuerlainId),
                    Name = "Shalimar",
                    Description = "Timeless oriental scent with vanilla, iris, and amber notes",
                    Price = 140.00M,
                    ImageUrl = "https://douglas.bg/media/catalog/product/cache/dd4850ad4231b6306bceadf38a0bbeed/1/_/1_4439.jpg",
                    CreatedOn = DateTime.UtcNow,
                    CategoryId = Guid.Parse(FragranceId),
                    BrandId = Guid.Parse(GuerlainId)
                },
                new Product
                {
                    Id = Guid.Parse(OpiumByYvesSaintLaurentId),
                    Name = "Opium",
                    Description = "Rich and spicy oriental fragrance with exotic undertones",
                    Price = 100.00M,
                    ImageUrl = "https://www.yslbeautyus.com/dw/image/v2/AANG_PRD/on/demandware.static/-/Sites-ysl-master-catalog/default/dwfd20b6ef/Fragrance/Fragrance/Opium_Eau_De_Toilette_Spray/3365440556386_Opium-Eau-De-Tpilette-Spray_01.jpg?sw=698&sh=698&sm=cut&sfrm=jpg&q=85",
                    CreatedOn = DateTime.UtcNow,
                    CategoryId = Guid.Parse(FragranceId),
                    BrandId = Guid.Parse(YvesSaintLaurentId)
                },
                new Product
                {
                    Id = Guid.Parse(BlackOrchidByTomFordId),
                    Name = "Black Orchid",
                    Description = "Luxurious blend of black truffle, vanilla, and orchid",
                    Price = 180.00M,
                    ImageUrl = "https://www.sephora.com/productimages/sku/s1007731-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    CategoryId = Guid.Parse(FragranceId),
                    BrandId = Guid.Parse(TomFordId)
                },
                new Product
                {
                    Id = Guid.Parse(AcquaDiGioByGiorgioArmaniId),
                    Name = "Acqua di Gio",
                    Description = "Fresh and aquatic scent with notes of citrus and rosemary",
                    Price = 85.00M,
                    ImageUrl = "https://www.sephora.com/productimages/sku/s397299-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    CategoryId = Guid.Parse(FragranceId),
                    BrandId = Guid.Parse(ArmaniId)
                },
                new Product
                {
                    Id = Guid.Parse(TerreDhermesByHermesId),
                    Name = "Terre d'Hermès",
                    Description = "Citrusy and woody fragrance with notes of grapefruit and cedar",
                    Price = 120.00M,
                    ImageUrl = "https://www.sephora.com/productimages/sku/s915447-main-zoom.jpg?imwidth=612",
                    CreatedOn = DateTime.UtcNow,
                    CategoryId = Guid.Parse(FragranceId),
                    BrandId = Guid.Parse(HermesId)
                },
                new Product
                {
                    Id = Guid.Parse(AventusByCreedId),
                    Name = "Aventus",
                    Description = "Fresh and fruity scent with notes of pineapple and blackcurrant",
                    Price = 250.00M,
                    ImageUrl = "https://creedboutique.com/cdn/shop/files/aventus-100ml-bottle_3413e5f4-3eee-40b3-8451-2546a370ec5b.jpg?v=1700498936&width=1500",
                    CreatedOn = DateTime.UtcNow,
                    CategoryId = Guid.Parse(FragranceId),
                    BrandId = Guid.Parse(CreedId)
                }
            };
        }
    }
}

