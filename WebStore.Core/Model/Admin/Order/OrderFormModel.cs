using WebStore.Core.Model.Admin.Product;

namespace WebStore.Core.Model.Admin.Order
{
    public class OrderFormModel
    {
        public int OrderStatusId { get; set; }
        public IEnumerable<ProductOrderModel> Products { get; set; } = null!;
    }
}
