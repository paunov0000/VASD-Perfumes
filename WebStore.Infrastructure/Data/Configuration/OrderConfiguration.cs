using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Infrastructure.Data.Entities;

using static WebStore.Infrastructure.Data.Constants.ConfigurationConstants.Product;

namespace WebStore.Infrastructure.Data.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(CreateOrders());
            builder.HasMany(o => o.Products)
                .WithMany(p => p.Orders)
                .UsingEntity(j => j.HasData(
                    new
                    {
                        OrdersId = 1,
                        ProductsId = Guid.Parse(Chanel05Id)
                    },
                    new
                    {
                        OrdersId = 1,
                        ProductsId = Guid.Parse(BlackOrchidByTomFordId)
                    },
                    new
                    {
                        OrdersId = 1,
                        ProductsId = Guid.Parse(AventusByCreedId)
                    }
                    ));
        }

        private List<Order> CreateOrders()
        {
            return new List<Order>
            {
                new Order
                {
                    Id = 1,
                    CustomerId = Guid.Parse("2D963508-BD53-4713-A82E-189A8DCC42B9"),
                    OrderDate = DateTime.UtcNow,
                    OrderStatusId = 3
                }
            };
        }
    }
}
