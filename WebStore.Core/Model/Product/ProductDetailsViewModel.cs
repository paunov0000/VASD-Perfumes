namespace WebStore.Core.Model.Product
{
    public class ProductDetailsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ProductImg { get; set; } = null!;
        public string BrandName { get; set; } = null!;
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public bool OnSale { get; set; }
        public string CategoryName { get; set; } = null!;
        public string SubcategoryName { get; set; } = null!;

    }
}
