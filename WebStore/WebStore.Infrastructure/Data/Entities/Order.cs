using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebStore.Core.Constants;

namespace WebStore.Infrastructure.Data.Entities
{
    [Comment("Holds info for the Order entity")]
    public class Order
    {
        [Key]
        [Comment("Primary key of the order")]
        public int Id { get; set; }

        [Required]
        [Comment("Date of the order")]
        public DateTime OrderDate { get; set; }

        [Required]
        [Comment("Status of the order")]
        public OrderStatus Status { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        [Comment("Foreign key of the user")]
        public Guid UserId { get; set; }

        [Required]
        public ApplicationUser User { get; set; } = null!;

        [Required]
        [Comment("Products of the order")]
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
