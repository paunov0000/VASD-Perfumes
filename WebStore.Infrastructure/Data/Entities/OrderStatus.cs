using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static WebStore.Infrastructure.Data.Constants.ModelConstants.OrderStatus;

namespace WebStore.Infrastructure.Data.Entities
{
    [Comment("Holds info for the Status of the Order")]
    public class OrderStatus
    {
        [Key]
        [Comment("Primary key of the Order Status")]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Name of the Order Status")]
        public string Name { get; set; } = null!;
    }
}
