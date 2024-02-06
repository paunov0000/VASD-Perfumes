using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Core.Model.Product;

namespace WebStore.Core.Contracts
{
    public interface IProductService
    {
        /// <summary>
        /// Fetches all Product entities from the database and maps them to an IEnumerable of ProductViewModel
        /// </summary>
        /// <returns>An IEnumerable of ProductViewModel</returns>
        Task<IEnumerable<ProductViewModel>> GetAllProductsAsync();


        /// <summary>
        /// Fetches the 12 most recent products from the database and maps them to an IEnumerable of ProductViewModel
        /// </summary>
        /// <returns>An IEnumerable of ProductViewModel</returns>
        Task<IEnumerable<ProductViewModel>> Get12MostRecent();


        /// <summary>
        /// Fetches the most sold products from the database and maps them to an IEnumerable of ProductViewModel
        /// </summary>
        /// <returns>An IEnumerable of ProductViewModel</returns>
        Task<IEnumerable<ProductViewModel>> GetMostSold();


        /// <summary>
        /// Fetches the products that are currently on sale from the database and maps them to an IEnumerable of ProductViewModel
        /// </summary>
        /// <returns>An IEnumerable of ProductViewModel</returns>
        Task<IEnumerable<ProductViewModel>> GetOnSale();


        /// <summary>
        /// Adds a new Product entity to the database
        /// </summary>
        /// <param name="model">View model which holds the data</param>
        Task AddProductAsync(ProductAddViewModel model);


        /// <summary>
        /// Fetches all ProductCategory entities from the database and maps them to an IEnumerable of ProductCategoryFormViewModel
        /// </summary>
        /// <returns>An IEnumerable of ProductCategoryFormViewModel</returns>
        Task<IEnumerable<ProductCategoryFormViewModel>> GetAllProductCategories();


        /// <summary>
        /// Fetches a Product entity from the database by its id and maps it to a ProductAddViewModel
        /// </summary>
        /// <param name="id">Unique identifier of the entity</param>
        /// <returns>Product entity mapped to ProductAddViewModel</returns>
        Task<ProductAddViewModel> GetProductByIdAsync(Guid id);


        /// <summary>
        /// Edits/Updates a Product entity in the database
        /// </summary>
        /// <param name="model">A viewmodel which holds the data</param>
        Task EditProductAsync (ProductAddViewModel model);
    }
}
