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
        Task<IEnumerable<ProductViewModel>> GetAllProductsAsync();

        Task<IEnumerable<ProductViewModel>> Get12MostRecent();

        Task<IEnumerable<ProductViewModel>> GetMostSold();

        Task<IEnumerable<ProductViewModel>> GetOnSale();

        Task AddProductAsync(ProductAddViewModel model);
    }
}
