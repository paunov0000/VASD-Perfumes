using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Infrastructure.Data.Entities
{
    public class FragrancePyramid
    {
        [Key]
        public int Id { get; set; }

        public string? TopNotes { get; set; }

        public string? MiddleNotes { get; set; }

        public string? BaseNotes { get; set; }

        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
