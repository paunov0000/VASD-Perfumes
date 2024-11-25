using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Core.Model.Order;

namespace WebStore.Core.Contracts
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderViewModel>> GetUserOrders(string userId);
    }
}
