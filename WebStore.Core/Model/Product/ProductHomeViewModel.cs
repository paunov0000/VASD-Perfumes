using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Core.Model.Product
{
    public class ProductHomeViewModel
    {
        public IEnumerable<ProductViewModel> MostRecent { get; set; } = null!;

        public IEnumerable<ProductViewModel> MostSold { get; set; } = null!;

        public IEnumerable<ProductViewModel> OnSale { get; set; } = null!;

        public IEnumerable<ProductViewModel> AllProducts { get; set; } = null!;
    }
}
