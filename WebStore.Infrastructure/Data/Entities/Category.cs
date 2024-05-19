using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static WebStore.Infrastructure.Data.Constants.ModelConstants.Category;

namespace WebStore.Infrastructure.Data.Entities
{
    [Comment("Holds info for the Product Category entity")]
    public class Category
    {
        [Key]
        [Comment("Primary key of the product category")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Name of the product category")]
        public string Name { get; set; } = null!;

        //[Required]
        //[MaxLength(DescriptionMaxLength)]
        //[Comment("Description of the product category")]
        //public string Description { get; set; } = null!;
        //public string Image { get; set; } = null!;

        [Required]
        [Comment("Collection of products for the given Category")]
        public ICollection<Product> Products { get; set; } = new List<Product>();

        [Required]
        [Comment("Collection of subcategories for the given Category")]
        public ICollection<ParentSubcategory> ParentSubcategories { get; set; } = new List<ParentSubcategory>();
    }
}
