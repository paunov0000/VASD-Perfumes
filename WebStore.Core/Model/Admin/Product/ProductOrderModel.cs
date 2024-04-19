using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Core.Model.Admin.Product
{
    public class ProductOrderModel
    {
        public string Name { get; set; } = null!;

        public int Quantity { get; set; }
    }
}
