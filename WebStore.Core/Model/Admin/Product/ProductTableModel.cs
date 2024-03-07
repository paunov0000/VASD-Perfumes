using System.ComponentModel.DataAnnotations.Schema;
using WebStore.Infrastructure.Data.Entities;

namespace WebStore.Core.Model.Admin.Product
{
    public class ProductTableModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string BrandName { get; set; } = null!;

        public decimal Price { get; set; }

        public int SoldCount { get; set; }

        public int Quantity { get; set; }

        public bool OnSale { get; set; }

        public string CategoryName { get; set; }


    }
}
