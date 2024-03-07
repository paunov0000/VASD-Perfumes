using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Core.Contracts.Admin;
using WebStore.Core.Model.Admin.Product;
using WebStore.Core.Model.Product;
using WebStore.Infrastructure.Common;
using WebStore.Infrastructure.Data.Entities;

namespace WebStore.Core.Services.Admin
{
    public class ProductManageService : IProductManageService
    {
        private readonly IRepository repo;

        public ProductManageService(IRepository _repo)
        {
            repo = _repo;
        }
        public async Task<IEnumerable<ProductTableModel>> GetAllProductsAsync()
        {
           return await repo.AllReadonly<Product>()
                .Select(p => new ProductTableModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    BrandName = p.Brand.Name,
                    Price = p.Price,
                    SoldCount = p.SoldCount,
                    CategoryName = p.Category.Name,
                    OnSale = p.OnSale,
                    Quantity = p.Quantity,
                })
                .ToListAsync();
        }
    }
}
