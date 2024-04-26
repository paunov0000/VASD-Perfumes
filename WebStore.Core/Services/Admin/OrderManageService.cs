using Microsoft.EntityFrameworkCore;
using WebStore.Core.Contracts.Admin;
using WebStore.Core.Model.Admin.Order;
using WebStore.Core.Model.Admin.OrderStatus;
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
                "date-desc" => queryable.OrderByDescending(o => o.OrderDate),
                _ =>  queryable.OrderBy(o=>o.OrderDate)
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

        public async Task<List<OrderStatusFormModel>> GetAllOrderStatuses()
        {
            return await repo.AllReadonly<OrderStatus>()
                .Select(os=> new OrderStatusFormModel()
                {
                    Id=os.Id,
                    Name = os.Name,
                })
                .ToListAsync();
        }

        public async Task<Order> GetOrderById(int id)
        {
            return await repo.GetByIdAsync<Order>(id); //TODO: this way or return the model not the entity? must research
        }
    }
}
