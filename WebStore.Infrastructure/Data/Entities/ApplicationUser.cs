using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace WebStore.Infrastructure.Data.Entities
{
    [Comment("Holds info for the Application User entity")]
    public class ApplicationUser : IdentityUser<Guid>
    {
        [Comment("First name of the ApplicationUser")]
        public string? FirstName { get; set; }

        [Comment("Last name of the ApplicationUser")]
        public string? LastName { get; set; }

        [Comment("Address of the ApplicationUser")]
        public string? Address { get; set; }

        [Comment("City of the ApplicationUser")]
        public string? City { get; set; }

        [Comment("Country of the ApplicationUser")]
        public string? Country { get; set; }

        [Comment("Postal code of the ApplicationUser")]
        public string? PostalCode { get; set; }

        [Comment("Region of the ApplicationUser")]
        public string? Region { get; set; }

        [Comment("Date of creating the ApplicationUser")]
        public DateTime CreatedOn { get; set; }

        [Comment("Orders of the ApplicationUser")]
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
