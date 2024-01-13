using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static WebStore.Core.Constants.EntityConstant.Review;

namespace WebStore.Infrastructure.Data.Entities
{
    public class Review
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(CommentMaxLength)]
        public string Comment { get; set; } = null!;

        [Required]
        public int Rating { get; set; }

        [Required]
        public DateTime Created { get; set; } 

        public DateTime Updated { get; set; }

        [Required]
        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }

        [Required]
        public Product Product { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        public ApplicationUser User { get; set; } = null!;
    }
}
