using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Core.Model.Admin.Product;
using WebStore.Core.Model.Product;

namespace WebStore.Core.Contracts.Admin
{
    public interface IProductManageService
    {
        Task<IEnumerable<ProductTableModel>> GetAllProductsAsync();

    }
}
