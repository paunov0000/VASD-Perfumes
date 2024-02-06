namespace WebStore.Core.Model.Product
{
    public class ProductViewModel : ProductAddViewModel
    {
        public Guid Id { get; set; }
        public int SoldCount { get; set; }
    }
}
