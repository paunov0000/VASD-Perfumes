using Microsoft.EntityFrameworkCore;
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
                     SubcategoryName = p.Subcategory.Name,
                     OnSale = p.OnSale,
                     Quantity = p.Quantity,
                 })
                 .ToListAsync();
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

        public async Task<IEnumerable<CategoryFormViewModel>> GetAllCategories()
        {
            var result = await this.repo.AllReadonly<Category>().Select(x => new CategoryFormViewModel()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();

            return result;
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
    }
}
