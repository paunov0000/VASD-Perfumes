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
            builder.HasData(CreateOrders());                                          //TODO: idk if seeding the mapping tabble like this will work lol
            builder.HasMany(o => o.Products)                                          //TODO: idk if seeding the mapping tabble like this will work lol
                .WithMany(p => p.Orders)                                              //TODO: idk if seeding the mapping tabble like this will work lol
                .UsingEntity(j => j.HasData(                                          //TODO: idk if seeding the mapping tabble like this will work lol
                    new                                                               //TODO: idk if seeding the mapping tabble like this will work lol
                    {                                                                 //TODO: idk if seeding the mapping tabble like this will work lol
                        OrdersId = 1,                                                 //TODO: idk if seeding the mapping tabble like this will work lol
                        ProductsId = Guid.Parse(Chanel05Id)                           //TODO: idk if seeding the mapping tabble like this will work lol
                    },                                                                //TODO: idk if seeding the mapping tabble like this will work lol
                    new                                                               //TODO: idk if seeding the mapping tabble like this will work lol
                    {                                                                 //TODO: idk if seeding the mapping tabble like this will work lol
                        OrdersId = 1,                                                 //TODO: idk if seeding the mapping tabble like this will work lol
                        ProductsId = Guid.Parse(BlackOrchidByTomFordId)               //TODO: idk if seeding the mapping tabble like this will work lol
                    },                                                                //TODO: idk if seeding the mapping tabble like this will work lol
                    new                                                               //TODO: idk if seeding the mapping tabble like this will work lol
                    {                                                                 //TODO: idk if seeding the mapping tabble like this will work lol
                        OrdersId = 1,                                                 //TODO: idk if seeding the mapping tabble like this will work lol
                        ProductsId = Guid.Parse(AventusByCreedId)                     //TODO: idk if seeding the mapping tabble like this will work lol
                    }                                                                 //TODO: idk if seeding the mapping tabble like this will work lol
                    ));                                                               //TODO: idk if seeding the mapping tabble like this will work lol
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
