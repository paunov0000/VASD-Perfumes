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
                BrandId = model.BrandId,
                CategoryId = model.CategoryId,
                Id = model.Id
            });

            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductViewModel>> GetMostRecent(int count)
        {
            var result = await this.repo.AllReadonly<Product>()
                .Where(p => p.IsActive)
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

        public async Task<IEnumerable<ProductViewModel>> GetAllProductsAsync(bool isActive = true)
        {
            IEnumerable<ProductViewModel> result;

            if (isActive == false)
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
                .Where(p => p.IsActive)
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
                .Where(p => p.IsActive)
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
            var result = await this.repo.AllReadonly<Product>(p => p.OnSale == true && p.IsActive)
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

        public async Task<IEnumerable<CategoryFormViewModel>> GetAllCategories()
        {
            return await this.repo.AllReadonly<Category>().Select(x => new CategoryFormViewModel()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();
        }

        public async Task<ProductAddViewModel> GetProductByIdAsync(Guid id) //TODO: Add exception handling
        {
            var product = await this.repo.GetByIdAsync<Product>(id);

            if (product.IsActive == false) //TODO: Is it okay to check if isActive here or should it be checked in the controller?
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
                BrandId = product.BrandId,
                CategoryId = product.CategoryId
            };
        }

        public async Task EditProductAsync(ProductAddViewModel model) //TODO: Add exception handling
        {
            var entity = await repo.GetByIdAsync<Product>(model.Id);

            if (entity.IsActive == false) //TODO: Is it okay to check if isActive here or should it be checked in the controller?
            {
                throw new InvalidOperationException("Product not found");
            }

            entity.Description = model.Description;
            entity.ImageUrl = model.ImageUrl;
            entity.Name = model.Name;
            entity.Price = model.Price;
            entity.BrandId = model.BrandId;
            entity.CategoryId = model.CategoryId;

            await repo.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(Guid id)
        {
            var entity = await repo.GetByIdAsync<Product>(id);

            if (entity.IsActive == false) //TODO: Is it okay to check if isActive here or should it be checked in the controller?
            {
                throw new InvalidOperationException("Product not found");
            }

            entity.IsActive = false;

            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductViewModel>> GetFilteredProductsAsync(string search)
        {
            var result = await this.repo.AllReadonly<Product>()
                .Where(p => p.Name.StartsWith(search))
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

        public async Task<IEnumerable<BrandFormViewModel>> GetAllBrands()
        {
            var result = await this.repo.AllReadonly<Brand>().Select(x => new BrandFormViewModel()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();

            return result;
        }
    }
}
