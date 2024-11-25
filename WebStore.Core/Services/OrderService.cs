using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Core.Contracts;
using WebStore.Core.Model.Order;
using WebStore.Infrastructure.Common;
using WebStore.Infrastructure.Data.Entities;

namespace WebStore.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepository repo;

        public OrderService(IRepository repo)
        {
            this.repo = repo;
        }

        public async Task<IEnumerable<OrderViewModel>> GetUserOrders(string userId)
        {
            var result = await this.repo
                .AllReadonly<Order>()
                .Include(o => o.Products)
                .Where(o => o.CustomerId.ToString() == userId)
                .Select(o => new OrderViewModel
                {
                    Id = o.Id,
                    OrderDate = o.OrderDate,
                    TotalSum = o.Products.Sum(p => p.Price * p.Quantity),
                    OrderStatus = o.OrderStatus.Name,
                }).ToListAsync();

            return result;
        }
    }
}
