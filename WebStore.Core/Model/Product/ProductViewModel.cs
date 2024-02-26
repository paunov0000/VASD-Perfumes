using System.ComponentModel.DataAnnotations;

namespace WebStore.Core.Model.Product
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public string ImageUrl { get; set; } = null!;

        public string Manufacturer { get; set; } = null!;

        public Guid ProductCategoryId { get; set; }
        public int SoldCount { get; set; }
    }
}
