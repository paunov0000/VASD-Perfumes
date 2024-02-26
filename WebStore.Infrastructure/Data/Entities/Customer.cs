using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Infrastructure.Data.Entities
{
    [Comment("Holds info for the Customer entity")]
    public class Customer
    {
        [Comment("Primary key of the customer")]
        public Guid Id { get; set; }

        [Comment("Address of the Customer entity")]
        public string? Address { get; set; }

        [Comment("City of the Customer entity")]
        public string? City { get; set; }

        [Comment("State of the Customer entity")]
        public string? State { get; set; }

        [Comment("Zip of the Customer entity")]
        public string? Zip { get; set; }

        [Comment("Foreign key to the ApplicationUser entity")]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        public ApplicationUser User { get; set; } = null!;


        [Comment("Orders of the Customer entity")]
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
