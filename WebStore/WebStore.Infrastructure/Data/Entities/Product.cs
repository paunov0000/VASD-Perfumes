using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static WebStore.Infrastructure.Data.Constants.ModelConstants.Product;

namespace WebStore.Infrastructure.Data.Entities
{
    [Comment("Holds info for the Product entity")]
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

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public DateTime AddedOn { get; set; }

        [Required]
        public int SoldCount { get; set; }

        [Required]
        public bool OnSale { get; set; }

        [Required]
        [ForeignKey(nameof(ProductCategory))]
        [Comment("Foreign key of the product category")]
        public Guid ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; } = null!;

        [Required]
        [Comment("Orders of the product")]
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
