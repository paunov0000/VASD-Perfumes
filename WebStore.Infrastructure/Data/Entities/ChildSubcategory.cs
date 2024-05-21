using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Infrastructure.Data.Entities
{
    public class ChildSubcategory
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [ForeignKey(nameof(Product))]
        public Guid? ProductId { get; set; }
        public Product Product { get; set; } = null!;

        [Required]
        public ICollection<ParentSubcategory> ParentSubcategories { get; set; } = new List<ParentSubcategory>();
    }
}
