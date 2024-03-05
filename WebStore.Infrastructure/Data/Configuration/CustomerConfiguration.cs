using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Infrastructure.Data.Entities;

namespace WebStore.Infrastructure.Data.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(CreateCustomers());
        }

        private List<Customer> CreateCustomers()
        {
            var customers = new List<Customer>();

            var customer = new Customer
            {
                Id = Guid.Parse("2d963508-bd53-4713-a82e-189a8dcc42b9"),
                City = "Sofia",
                Address = "bul. Vitosha 1",
                State = "Sofia",
                Zip = "1000",
                UserId = Guid.Parse("c0a0d5a0-4b6a-4b6a-8f4a-0c8f0b6f0b6c"),
            };

            customers.Add(customer);

            return customers;
        }
    }
}
