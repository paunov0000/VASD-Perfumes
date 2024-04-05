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
        public async Task<IList<ProductTableModel>> GetAllProductsAsync()
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
                     IsActive = p.IsActive
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
                SubcategoryId = model.SubcategoryId,
                Id = model.Id,
                IsActive = model.IsActive,
                Quantity = model.Quantity,
            });

            await repo.SaveChangesAsync();
        }

        public async Task EditProductAsync(ProductAddViewModel model) //TODO: Add exception handling
        {
            var entity = await repo.GetByIdAsync<Product>(model.Id);

            //if (entity.IsActive == false) //TODO: Is it okay to check if isActive here or should it be checked in the controller?
            //{
            //    throw new InvalidOperationException("Product not found");
            //}

            entity.Description = model.Description;
            entity.ImageUrl = model.ImageUrl;
            entity.Name = model.Name;
            entity.Price = model.Price;
            entity.BrandId = model.BrandId;
            entity.CategoryId = model.CategoryId;
            entity.SubcategoryId = model.SubcategoryId;
            entity.OnSale = model.OnSale;
            entity.IsActive = model.IsActive;
            entity.Quantity = model.Quantity;

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

        public async Task<IEnumerable<SubcategoryFormModel>> GetAllSubcategories()
        {
            var result = await this.repo.AllReadonly<Subcategory>().Select(x => new SubcategoryFormModel()
            {
                Id = x.Id,
                Name = x.Name
            })
                .ToListAsync();

            return result;

        }

        public async Task RestockProductAsync(Guid id, int count)
        {
            var entity = await this.repo.GetByIdAsync<Product>(id);

            entity.Quantity += count;

            await repo.SaveChangesAsync();
        }

        public async Task<IList<ProductTableModel>> GetProducts(int count)
        {
            var result = await this.repo.AllReadonly<Product>().Take(count).Select(p => new ProductTableModel()
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
                IsActive = p.IsActive
            }).ToListAsync();

            return result;
        }

        public IQueryable<Product> GetIQueryableProducts()
        {
            return repo.AllReadonly<Product>();
        }

        public IQueryable<Product> GetIQueryableProducts(int count)
        {
            return repo.AllReadonly<Product>().Take(count);
        }
    }
}
