using Microsoft.EntityFrameworkCore;
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

        public async Task AddProductAsync(ProductAddViewModel model)
        {
            await repo.AddAsync(new Product()
            {
                CreatedOn = DateTime.UtcNow,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                Name = model.Name,
                Price = model.Price,
                Manufacturer = model.Manufacturer,
                ProductCategoryId = model.ProductCategoryId,
                Id = model.Id
            });

            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductViewModel>> GetMostRecent(int count)
        {
            var result = await this.repo.AllReadonly<Product>()
                .Where(p => p.IsDeleted == false)
                .OrderByDescending(x => x.CreatedOn).Take(count).Select(x => new ProductViewModel()
                {
                    Description = x.Description,
                    Id = x.Id,
                    ImageUrl = x.ImageUrl,
                    Name = x.Name,
                    Price = x.Price

                }).ToListAsync();

            return result;
        }

        public async Task<IEnumerable<ProductViewModel>> GetAllProductsAsync(bool isDeleted)
        {
            IEnumerable<ProductViewModel> result;

            if (isDeleted)
            {
                result = await this.repo.AllReadonly<Product>()
                    .Select(x => new ProductViewModel()
                    {
                        Description = x.Description,
                        Id = x.Id,
                        ImageUrl = x.ImageUrl,
                        Name = x.Name,
                        Price = x.Price

                    }).ToListAsync();
            }
            else
            {
                result = await this.repo.AllReadonly<Product>()
                .Where(p => p.IsDeleted == false)
                .Select(x => new ProductViewModel()
                {
                    Description = x.Description,
                    Id = x.Id,
                    ImageUrl = x.ImageUrl,
                    Name = x.Name,
                    Price = x.Price

                }).ToListAsync();
            }

            return result;
        }

        public async Task<IEnumerable<ProductViewModel>> GetMostSold()
        {
            var result = await this.repo.AllReadonly<Product>()
                .Where(p => p.IsDeleted == false)
                .OrderByDescending(x => x.SoldCount)
                .Take(12)
                .Select(x => new ProductViewModel()
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
            var result = await this.repo.AllReadonly<Product>(p => p.OnSale == true && p.IsDeleted == false)
                .Select(x => new ProductViewModel()
                {
                    Description = x.Description,
                    Id = x.Id,
                    ImageUrl = x.ImageUrl,
                    Name = x.Name,
                    Price = x.Price

                }).ToListAsync();

            return result;
        }

        public async Task<IEnumerable<ProductCategoryFormViewModel>> GetAllProductCategories()
        {
            return await this.repo.AllReadonly<ProductCategory>().Select(x => new ProductCategoryFormViewModel()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();
        }

        public async Task<ProductAddViewModel> GetProductByIdAsync(Guid id) //TODO: Add exception handling
        {
            var product = await this.repo.GetByIdAsync<Product>(id);

            if (product.IsDeleted == true)
            {
                throw new InvalidOperationException("Entity not found");
            }

            return new ProductAddViewModel()
            {
                Description = product.Description,
                Id = product.Id,
                ImageUrl = product.ImageUrl,
                Name = product.Name,
                Price = product.Price,
                Manufacturer = product.Manufacturer,
                ProductCategoryId = product.ProductCategoryId

            };
        }

        public async Task EditProductAsync(ProductAddViewModel model) //TODO: Add exception handling
        {
            var entity = await repo.GetByIdAsync<Product>(model.Id);

            if (entity.IsDeleted == true)
            {
                throw new InvalidOperationException("Product not found");
            }

            entity.Description = model.Description;
            entity.ImageUrl = model.ImageUrl;
            entity.Name = model.Name;
            entity.Price = model.Price;
            entity.Manufacturer = model.Manufacturer;
            entity.ProductCategoryId = model.ProductCategoryId;

            await repo.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(Guid id)
        {
            var entity = await repo.GetByIdAsync<Product>(id);

            if (entity.IsDeleted == true)
            {
                throw new InvalidOperationException("Product not found");
            }

            entity.IsDeleted = true;

            await repo.SaveChangesAsync();
        }
    }
}
