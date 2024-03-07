using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    Name = "Chanel"
                },
                new Brand
                {
                    Id = Guid.Parse(MarcJacobsId),
                    Name = "Marc Jacobs"
                },
                new Brand
                {
                    Id = Guid.Parse(GucciId),
                    Name = "Gucci"
                },
                new Brand
                {
                    Id = Guid.Parse(ViktorRolfId),
                    Name = "Viktor&Rolf"
                },
                new Brand
                {
                    Id = Guid.Parse(GuerlainId),
                    Name = "Guerlain"
                },
                new Brand
                {
                    Id = Guid.Parse(YvesSaintLaurentId),
                    Name = "Yves Saint Laurent"
                },
                new Brand
                {
                    Id = Guid.Parse(TomFordId),
                    Name = "Tom Ford"
                },
                new Brand
                {
                    Id = Guid.Parse(ArmaniId),
                    Name = "Armani"
                },
                new Brand
                {
                    Id = Guid.Parse(HermesId),
                    Name = "Hermès"
                },
                new Brand
                {
                    Id = Guid.Parse(CreedId),
                    Name = "Creed"
                }

            };

           return brands;
        }
    }
}
