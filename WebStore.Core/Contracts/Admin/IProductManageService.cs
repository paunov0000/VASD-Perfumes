using WebStore.Core.Model.Admin.Product;
using WebStore.Core.Model.Product;

namespace WebStore.Core.Contracts.Admin
{
    public interface IProductManageService
    {

        /// <summary>
        /// Fetches all Product entities from the database and maps them to an IEnumerable of ProductTableModel
        /// </summary>
        /// <returns>An IEnumerable of ProductTableModel</returns>
        Task<IEnumerable<ProductTableModel>> GetAllProductsAsync();

        /// <summary>
        /// Fetches all Category entities from the database and maps them to an IEnumerable of CategoryFormViewModel
        /// </summary>
        /// <returns>An IEnumerable of CategoryFormViewModel</returns>
        Task<IEnumerable<CategoryFormViewModel>> GetAllCategories();


        /// <summary>
        /// Fetches all Brand entities from the database and maps them to an IEnumerable of BrandFormViewModel
        /// </summary>
        /// <returns>An IEnumerable of BrandFormViewModel</returns>
        Task<IEnumerable<BrandFormViewModel>> GetAllBrands();

        /// <summary>
        /// Adds a new Product entity to the database
        /// </summary>
        /// <param name="model">View model which holds the data</param>
        Task AddProductAsync(ProductAddViewModel model);

        /// <summary>
        /// Edits/Updates a Product entity in the database
        /// </summary>
        /// <param name="model">A viewmodel which holds the data</param>
        Task EditProductAsync(ProductAddViewModel model);

        /// <summary>
        /// Marks a Product entity from the database as inactive
        /// </summary>
        /// <param name="id">Unique identifier of the Entity performing actions on</param>
        Task DeleteProductAsync(Guid id);


        /// <summary>
        /// Fetches all Subcategory entities from the database and maps them to an IEnumerable of SubcategoryFormModel
        /// </summary>
        /// <returns>An IEnumerable of SubcategoryFormModel</returns>
        Task<IEnumerable<SubcategoryFormModel>> GetAllSubcategories();
    }
}
