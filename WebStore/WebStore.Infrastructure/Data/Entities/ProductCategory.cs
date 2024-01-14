using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static WebStore.Infrastructure.Data.Constants.EntityConstants.ProductCategory;

namespace WebStore.Infrastructure.Data.Entities
{
    public class ProductCategory
    {
        [Key]
        [Comment("Primary key of the product category")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Name of the product category")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        [Comment("Description of the product category")]
        public string Description { get; set; } = null!;
        //public string Image { get; set; } = null!;

        //[Required]
        [Comment("Products of the product category")]
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
