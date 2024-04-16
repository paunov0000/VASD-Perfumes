using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebStore.Infrastructure.Data.Entities;

namespace WebStore.Infrastructure.Data.Configuration
{
    internal class OrderStatusConfiguration : IEntityTypeConfiguration<OrderStatus>
    {
        public void Configure(EntityTypeBuilder<OrderStatus> builder)
        {
            builder.HasData(CreateOrderStatuses());
        }

        private List<OrderStatus> CreateOrderStatuses()
        {
            return new List<OrderStatus>()
            {
                new OrderStatus()
                {
                    Id = 1,
                    Name = "Pending"
                },
                new OrderStatus()
                {
                    Id = 2,
                    Name = "Awaiting Payment"
                },
                new OrderStatus()
                {
                    Id= 3,
                    Name="Awaiting Fulfillment"
                },
                new OrderStatus()
                {
                    Id= 4,
                    Name="Awaiting Shipment"
                },
                new OrderStatus()
                {
                    Id= 5,
                    Name="Awaiting Pickup"
                },
                new OrderStatus()
                {
                    Id= 6,
                    Name="Partially Shipped"
                },
                new OrderStatus()
                {
                    Id= 7,
                    Name="Completed"
                },
                new OrderStatus()
                {
                    Id= 8,
                    Name="Shipped"
                },
                new OrderStatus()
                {
                    Id= 9,
                    Name="Canceled"
                },
                new OrderStatus()
                {
                    Id= 10,
                    Name="Declined"
                },
                new OrderStatus()
                {
                    Id= 11,
                    Name="Refunded"
                },
                new OrderStatus()
                {
                    Id= 12,
                    Name="Disputed"
                },
                new OrderStatus()
                {
                    Id= 13,
                    Name="Manual Verification Required"
                },
                new OrderStatus()
                {
                    Id= 14,
                    Name="Partially Refunded"
                }
            };
        }
    }
}
