using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.Core.Contracts.Admin;
using WebStore.Core.Model.Admin.Product;
using WebStore.Core.Model.Product;

namespace WebStore.Core.Services.Admin
{
    public class ProductService : IProductService
    {
        public Task<IEnumerable<ProductTableModel>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
