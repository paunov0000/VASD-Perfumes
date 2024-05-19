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

        [ForeignKey(nameof(ParentSubcategory))]
        public Guid ParentSubcategoryId { get; set; }

        [Required]
        public ParentSubcategory ParentSubcategory { get; set; } = null!;
    }
}
