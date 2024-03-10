using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebStore.Infrastructure.Data.Constants;

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

        [Comment("Foreign key of the OrderStatus")]
        [ForeignKey(nameof(OrderStatus))]
        public int OrderStatusId { get; set; }

        [Required]
        [Comment("Navigation property to the OrderStatus")]
        public OrderStatus OrderStatus { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Customer))]
        [Comment("Foreign key of the Customer")]
        public Guid CustomerId { get; set; }

        [Required]
        [Comment("Navigation property to the Customer")]
        public Customer Customer { get; set; } = null!;

        [Required]
        [Comment("Products of the Order")]
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
