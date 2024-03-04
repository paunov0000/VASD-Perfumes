using System.ComponentModel.DataAnnotations.Schema;
using WebStore.Infrastructure.Data.Entities;

namespace WebStore.Core.Model.Admin.Product
{
    public class ProductTableModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Manufacturer { get; set; } = null!;

        public decimal Price { get; set; }

        public int SoldCount { get; set; }

        [ForeignKey(nameof(ProductCategory))]
        public Guid ProductCategoryId { get; set; }

        public ProductCategory ProductCategory { get; set; } = null!;
    }
}
