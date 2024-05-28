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
                    Price = x.Price,
                    OnSale = x.OnSale,

                }).ToListAsync();

            return result;
        }


        public async Task<IEnumerable<ProductViewModel>> GetAllProductsAsync()
        {
            var result = await this.repo.AllReadonly<Product>()
             .Where(p => p.IsActive)
             .Select(x => new ProductViewModel()
             {
                 Description = x.Description,
                 Id = x.Id,
                 ImageUrl = x.ImageUrl,
                 Name = x.Name,
                 Price = x.Price,
                 OnSale = x.OnSale,

             }).ToListAsync();


            return result;
        }


        public async Task<IEnumerable<ProductViewModel>> GetMostSold(int count)
        {
            var result = await this.repo.AllReadonly<Product>()
                .Where(p => p.IsActive)
                .OrderByDescending(x => x.SoldCount)
                .Take(count)
                .Select(x => new ProductViewModel()
                {
                    Description = x.Description,
                    Id = x.Id,
                    ImageUrl = x.ImageUrl,
                    Name = x.Name,
                    Price = x.Price,
                    OnSale = x.OnSale,

                }).ToListAsync();

            return result;
        }


        public async Task<IEnumerable<ProductViewModel>> GetOnSale(int count)
        {
            var result = await this.repo.AllReadonly<Product>(p => p.OnSale == true && p.IsActive)
                .Take(count)
                .Select(x => new ProductViewModel()
                {
                    Description = x.Description,
                    Id = x.Id,
                    ImageUrl = x.ImageUrl,
                    Name = x.Name,
                    Price = x.Price,
                    OnSale = x.OnSale,

                }).ToListAsync();

            return result;
        }


        public async Task<IEnumerable<ProductViewModel>> GetProductsByName(string search)
        {
            var result = await this.repo.AllReadonly<Product>()
                .Where(p => p.Name.StartsWith(search) && p.IsActive == true)
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


        public async Task<ProductAddViewModel> GetProductByIdAsync(Guid id) //TODO: Add exception handling
        {
            var product = await this.repo.GetByIdAsync<Product>(id);

            //if (product.IsActive == false) //TODO: Is it okay to check if isActive here or should it be checked in the controller?
            //{
            //    throw new InvalidOperationException("Entity not found");
            //}

            return new ProductAddViewModel()
            {
                Description = product.Description,
                Id = product.Id,
                ImageUrl = product.ImageUrl,
                Name = product.Name,
                Price = product.Price,
                OriginalPrice = product.OriginalPrice,
                BrandId = product.BrandId,
                CategoryId = product.CategoryId,
                SubcategoryId = product.ParentSubcategoryId,
                Quantity = product.Quantity,
                IsActive = product.IsActive,
                OnSale = product.OnSale
            };
        }

        public async Task<ProductDetailsViewModel> GetProductDetailsById(Guid id)
        {
            var entity = await this.repo.AllReadonly<Product>()
                .Include(x => x.Brand)
                .Include(x => x.Category)
                .Include(x => x.ParentSubcategory)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null)
            {
                throw new InvalidOperationException("Entity not found");
            }

            return new ProductDetailsViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                ProductImg = entity.ImageUrl,
                BrandName = entity.Brand.Name,
                CategoryName = entity.Category.Name,
                SubcategoryName = entity.ParentSubcategory.Name,
                Price = entity.Price
            };
        }

        public async Task<ProductCartViewModel> GetProductCartModelById(Guid id)
        {
            var entity = await this.repo.GetByIdAsync<Product>(id);

            if (entity == null)
            {
                throw new InvalidOperationException("Entity not found");
            }

            return new ProductCartViewModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                Quantity = entity.Quantity
            };
        }
    }
}
