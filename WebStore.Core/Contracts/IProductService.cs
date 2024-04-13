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
        /// Fetches all Product entities from the database which match the search string and maps them to an IEnumerable of ProductViewModel
        /// </summary>
        /// <param name="search">String filter which is applied</param>
        /// <returns>An IEnumerable of ProductViewModel</returns>
        Task<IEnumerable<ProductViewModel>> GetFilteredProductsAsync(string search);


        /// <summary>
        /// Fetches the 12 most recent products from the database and maps them to an IEnumerable of ProductViewModel
        /// </summary>
        /// <param name="count">The quantity of most recent entities to be returned</param>
        /// <returns>An IEnumerable of ProductViewModel</returns>
        /// 
        Task<IEnumerable<ProductViewModel>> GetMostRecent(int count);


        /// <summary>
        /// Fetches the most sold products from the database and maps them to an IEnumerable of ProductViewModel
        /// </summary>
        /// <returns>An IEnumerable of ProductViewModel</returns>
        Task<IEnumerable<ProductViewModel>> GetMostSold(int count);


        /// <summary>
        /// Fetches the products that are currently on sale from the database and maps them to an IEnumerable of ProductViewModel
        /// </summary>
        /// <returns>An IEnumerable of ProductViewModel</returns>
        Task<IEnumerable<ProductViewModel>> GetOnSale();

        /// <summary>
        /// Fetches a Product entity from the database by its id and maps it to a ProductAddViewModel
        /// </summary>
        /// <param name="id">Unique identifier of the entity</param>
        /// <returns>Product entity mapped to ProductAddViewModel</returns>
        Task<ProductAddViewModel> GetProductByIdAsync(Guid id);

        Task<ProductDetailsViewModel> GetProductDetailsById(Guid id);

        Task<ProductCartViewModel> GetProductCartModelById(Guid id);
    }
}
