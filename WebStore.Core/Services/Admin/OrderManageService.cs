using Microsoft.EntityFrameworkCore;
using WebStore.Core.Contracts.Admin;
using WebStore.Core.Model.Admin.Order;
using WebStore.Infrastructure.Common;
using WebStore.Infrastructure.Data.Entities;

namespace WebStore.Core.Services.Admin
{
    public class OrderManageService : IOrderManageService
    {
        private readonly IRepository repo;

        public OrderManageService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<IEnumerable<OrderTableModel>> GetAllOrders(int count, string sort)
        {
            IQueryable<Order> queryable;

            if (count == 0)
            {
                queryable = repo.AllReadonly<Order>();
            }
            else
            {
                queryable = repo.AllReadonly<Order>()
                .Take(count);
            }

            queryable = sort switch
            {
                "date-asc" => queryable.OrderBy(o => o.OrderDate),
                "date-desc" => queryable.OrderByDescending(o=> o.OrderDate),
            };


            var result = await queryable.Select(o => new OrderTableModel()
            {
                Id = o.Id,
                CustomerEmail = o.Customer.User.Email,
                OrderDate = o.OrderDate,
                OrderStatus = o.OrderStatus.Name,
                TotalPrice = o.Products.Sum(p => p.Price),
            })
                .ToListAsync();

            return result;
        }
    }
}
