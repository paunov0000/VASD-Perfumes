using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Infrastructure.Data.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [Comment("First name of the user")]
        public string? FirstName { get; set; }

        [Comment("Last name of the user")]
        public string? LastName { get; set; }

        [Comment("Address of the user")]
        public string? Address { get; set; }

        [Comment("City of the user")]
        public string? City { get; set; }

        [Comment("Country of the user")]
        public string? Country { get; set; }

        [Comment("Postal code of the user")]
        public string? PostalCode { get; set; }

        [Comment("Region of the user")]
        public string? Region { get; set; }

        [Comment("Orders of the user")]
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
