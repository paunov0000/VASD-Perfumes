using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WebStore.Infrastructure.Data.Constants.ModelConstants.Brand;

namespace WebStore.Infrastructure.Data.Entities
{
    [Comment("Holds info for the Brand entity")]
    public class Brand
    {
        [Key]
        [Comment("The unique identifier for the brand.")]
        public Guid Id { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [Comment("The products that belong to the brand.")]
        public ICollection<Product> Products { get; set; } = new List<Product>();


    }
}
