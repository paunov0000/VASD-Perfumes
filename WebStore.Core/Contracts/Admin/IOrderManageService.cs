using WebStore.Core.Model.Admin.Order;

namespace WebStore.Core.Contracts.Admin
{
    public interface IOrderManageService
    {
        /// <summary>
        /// Fetches all Order entities from the database and maps them to an IEnumerable of OrderTableModel
        /// </summary>
        /// <returns>An IEnumerable of OrderTableModel</returns>
        Task<IEnumerable<OrderTableModel>> GetAllOrders(int count, string sort);
    }
}
