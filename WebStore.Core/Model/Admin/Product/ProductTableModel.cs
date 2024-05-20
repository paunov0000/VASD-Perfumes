using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebStore.Infrastructure.Data.Entities;

namespace WebStore.Core.Model.Admin.Product
{
    public class ProductTableModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        [Display(Name = "Brand")]
        public string BrandName { get; set; } = null!;

        public decimal Price { get; set; }

        [Display(Name = "Sold Count")]
        public int SoldCount { get; set; }

        public int Quantity { get; set; }

        [Display(Name = "On Sale")]
        public bool OnSale { get; set; }

        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        [Display(Name = "Category")]
        public string CategoryName { get; set; } = null!;

        [Display(Name = "Subcategory")]
        public string ParentSubcategoryName { get; set; } = null!;


    }
}
