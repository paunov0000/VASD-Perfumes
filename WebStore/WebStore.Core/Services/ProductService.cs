﻿using Microsoft.EntityFrameworkCore;
using WebStore.Core.Contracts;
using WebStore.Core.Model.Product;
using WebStore.Infrastructure.Common;
using WebStore.Infrastructure.Data.Entities;

namespace WebStore.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository repo;

        public ProductService(IRepository repo)
        {
            this.repo = repo;
        }

        public async Task<IEnumerable<ProductViewModel>> Get12MostRecent()
        {
            var result = await this.repo.AllReadonly<Product>().OrderByDescending(x => x.CreatedOn).Take(12).Select(x => new ProductViewModel()
            {
                Description = x.Description,
                Id = x.Id,
                ImageUrl = x.ImageUrl,
                Name = x.Name,
                Price = x.Price

            }).ToListAsync();

            return result;
        }

        public async Task<IEnumerable<ProductViewModel>> GetAllProductsAsync()
        {
            var result = await this.repo.AllReadonly<Product>().Select(x => new ProductViewModel()
            {
                Description = x.Description,
                Id = x.Id,
                ImageUrl = x.ImageUrl,
                Name = x.Name,
                Price = x.Price

            }).ToListAsync();

            return result;
        }

        public async Task<IEnumerable<ProductViewModel>> GetMostSold()
        {
            var result = await this.repo.AllReadonly<Product>().OrderByDescending(x => x.SoldCount).Take(12).Select(x => new ProductViewModel()
            {
                Description = x.Description,
                Id = x.Id,
                ImageUrl = x.ImageUrl,
                Name = x.Name,
                Price = x.Price

            }).ToListAsync();

            return result;
        }

        public async Task<IEnumerable<ProductViewModel>> GetOnSale()
        {
            var result = await this.repo.AllReadonly<Product>(p=> p.OnSale == true).Select(x => new ProductViewModel()
            {
                Description = x.Description,
                Id = x.Id,
                ImageUrl = x.ImageUrl,
                Name = x.Name,
                Price = x.Price

            }).ToListAsync();

            return result;
        }
    }
}
