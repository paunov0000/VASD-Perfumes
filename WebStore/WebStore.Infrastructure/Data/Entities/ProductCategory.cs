using System.ComponentModel.DataAnnotations;
using static WebStore.Core.Constants.EntityConstant.ProductCategory;

namespace WebStore.Infrastructure.Data.Entities
{
    public class ProductCategory
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;
        //public string Image { get; set; } = null!;

        //[Required]
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
