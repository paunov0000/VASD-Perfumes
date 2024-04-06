using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Infrastructure.Data.Entities;
using static WebStore.Infrastructure.Data.Constants.ConfigurationConstants.Brand;

namespace WebStore.Infrastructure.Data.Configuration
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasData(CreateBrands());
        }

        private IEnumerable<Brand> CreateBrands()
        {
            var brands = new List<Brand>
            {
                new Brand
                {
                    Id = Guid.Parse(ChanelId),
                    Name = "Chanel",
                    ImageUrl = "https://logos-world.net/wp-content/uploads/2020/04/Chanel-Logo.png",
                },
                new Brand
                {
                    Id = Guid.Parse(MarcJacobsId),
                    Name = "Marc Jacobs",
                    ImageUrl = "https://logos-world.net/wp-content/uploads/2023/09/Marc-Jacobs-Logo.png",
                },
                new Brand
                {
                    Id = Guid.Parse(GucciId),
                    Name = "Gucci",
                    ImageUrl = "https://logos-world.net/wp-content/uploads/2023/09/Gucci-Logo.png",
                },
                new Brand
                {
                    Id = Guid.Parse(ViktorRolfId),
                    Name = "Viktor&Rolf",
                    ImageUrl = "https://tukuz.com/wp-content/uploads/2020/05/viktor-rolf-logo-vector.png",
                },
                new Brand
                {
                    Id = Guid.Parse(GuerlainId),
                    Name = "Guerlain",
                    ImageUrl = "https://asset.brandfetch.io/idVWaf5oDD/idG5I2RSGp.jpeg?updated=1667940456056",
                },
                new Brand
                {
                    Id = Guid.Parse(YvesSaintLaurentId),
                    Name = "Yves Saint Laurent",
                    ImageUrl = "https://logowik.com/content/uploads/images/529_ysl.jpg",
                },
                new Brand
                {
                    Id = Guid.Parse(TomFordId),
                    Name = "Tom Ford",
                    ImageUrl = "https://1000logos.net/wp-content/uploads/2021/06/Tom-Ford-logo.png",
                },
                new Brand
                {
                    Id = Guid.Parse(ArmaniId),
                    Name = "Armani",
                    ImageUrl = "https://logos-world.net/wp-content/uploads/2020/11/Giorgio-Armani-Logo.png",
                },
                new Brand
                {
                    Id = Guid.Parse(HermesId),
                    Name = "Hermès",
                    ImageUrl = "https://assets.turbologo.com/blog/en/2021/07/07061330/hermes-symbol-logo-1.png",
                },
                new Brand
                {
                    Id = Guid.Parse(CreedId),
                    Name = "Creed",
                    ImageUrl = "https://aromacraze.com/images/thumbs/0025936_creed_420.jpeg",
                }

            };

            return brands;
        }
    }
}
