using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static WebStore.Infrastructure.Data.Constants.ModelConstants.Review;

namespace WebStore.Infrastructure.Data.Entities
{
    [Comment("Holds info for the Review entity")]
    public class Review
    {
        [Key]
        [Comment("Primary key of the review")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        [Comment("Title of the review")]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(CommentMaxLength)]
        [Comment("Comment of the review")]
        public string Comment { get; set; } = null!;

        [Required]
        [Comment("Rating for the reviewed product")]
        public int Rating { get; set; }

        [Required]
        [Comment("Date of creating the review")]
        public DateTime CreatedOn { get; set; }

        [Comment("Date of updating the review")]
        public DateTime? UpdatedOn { get; set; }

        [Required]
        [ForeignKey(nameof(Product))]
        [Comment("Foreign key of the product")]
        public Guid ProductId { get; set; }

        [Required]
        [Comment("Navigation property to the Product")]
        public Product Product { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Customer))]
        [Comment("Foreign key of the Customer")]
        public Guid CustomerId { get; set; }


        [Required]
        [Comment("Navigation property to the Customer")]
        public Customer Customer { get; set; } = null!;
    }
}
