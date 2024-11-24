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

        [Comment("Date of creating the ApplicationUser")]
        public DateTime CreatedOn { get; set; }

        [Comment("Date of birth of the ApplicationUser")]
        public DateTime? BirthDate { get; set; }

        public Customer? Customer { get; set; }

    }
}
