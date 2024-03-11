using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Infrastructure.Data.Entities
{
    [Comment("Holds info for the Product Subcategory entity")]
    public class Subcategory
    {
        [Key]
        [Comment("Primary key of the product subcategory")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Comment("Name of the product subcategory")]
        public string Name { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        [Comment("Foreign key to the Category entity")]
        public Guid CategoryId { get; set; }

        [Required]
        public Category Category { get; set; } = null!;

        [Required]
        [Comment("A collection of products which are related to the subcategory")]
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
