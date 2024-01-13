using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static WebStore.Core.Constants.EntityConstant.Product;

namespace WebStore.Infrastructure.Data.Entities
{
    [Comment($"Holds info for the {nameof(Product)} entity")]
    public class Product
    {
        [Key]
        [Comment("Primary key of the product")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Name of the product")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        [Comment("Description of the product")]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(ManufacturerMaxLength)]
        [Comment("Manufacturer of the product")]
        public string Manufacturer { get; set; } = null!;

        [Required]
        [Comment("Price of the product")]
        public decimal Price { get; set; }

        //[Required]
        //public string Image { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(ProductCategory))]
        [Comment("Foreign key of the product category")]
        public Guid ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; } = null!;
    }
}
