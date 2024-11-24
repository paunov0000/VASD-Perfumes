using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static WebStore.Infrastructure.Data.Constants.ModelConstants.Customer;

namespace WebStore.Infrastructure.Data.Entities
{
    [Comment("Holds info for the Customer entity")]
    public class Customer
    {
        [Comment("Primary key of the customer")]
        [Key]
        public Guid Id { get; set; }

        [Comment("Address of the Customer entity")]
        [MaxLength(AddressMaxLength)]
        public string? Address { get; set; }

        [Comment("City of the Customer entity")]
        [MaxLength(CityMaxLength)]
        public string? City { get; set; }

        [Comment("State of the Customer entity")]
        [MaxLength(StateMaxLength)]
        public string? State { get; set; }

        [Comment("Zip of the Customer entity")]
        [MaxLength(ZipMaxLength)]
        public string? Zip { get; set; }

        [Comment("Foreign key to the ApplicationUser entity")]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        [Comment("Navigation property to the ApplicationUser entity")]
        [Required]
        public ApplicationUser User { get; set; } = null!;


        [Comment("Orders of the Customer entity")]
        [Required]
        public ICollection<Order> Orders { get; set; } = new List<Order>();

        [Comment("Wishlist")]
        [Required]
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
