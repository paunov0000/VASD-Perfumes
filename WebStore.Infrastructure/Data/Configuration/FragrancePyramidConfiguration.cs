using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Infrastructure.Data.Entities;

using static WebStore.Infrastructure.Data.Constants.ConfigurationConstants.Product;

namespace WebStore.Infrastructure.Data.Configuration
{
    public class FragrancePyramidConfiguration : IEntityTypeConfiguration<FragrancePyramid>
    {
        public void Configure(EntityTypeBuilder<FragrancePyramid> builder)
        {
            builder.HasData(CreateFragrancePyramids());
        }

        private List<FragrancePyramid> CreateFragrancePyramids()
        {
            return new List<FragrancePyramid>
            {
                new FragrancePyramid
                {
                    Id = 1,
                    TopNotes = "Truffle, Gardenia, Black Currant, Ylang-Ylang, Jasmine, Bergamot, Mandarin Orange, Amalfi Lemon",
                    MiddleNotes="Orchid, Spices, Gardenia, Fruity Notes, Ylang-Ylang, Jasmine, Lostus",
                    BaseNotes ="Mexican Chocolate, Patchouli, Vanille, Incense, Amber, Sandalwood, Vetiver, White Musk",
                    ProductId = Guid.Parse(BlackOrchidByTomFordId)
                },
                new FragrancePyramid
                {
                    Id=2,
                    TopNotes="Jasmine",
                    MiddleNotes="Tuberose",
                    BaseNotes="Orris Root, Honeysuckle",
                    ProductId=Guid.Parse(GucciBloomId)
                },
                new FragrancePyramid
                {
                    Id=3,
                    TopNotes="Mandarin Orange, Bergamot, Lily-of-the-Valley",
                    MiddleNotes="Myrhh, Jasmine",
                    BaseNotes="Opoponax, Amber, Patchouli, Vanille",
                    ProductId=Guid.Parse(OpiumByYvesSaintLaurentId)
                }
            };
        }
    }
}
