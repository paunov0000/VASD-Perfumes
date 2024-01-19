using Microsoft.EntityFrameworkCore;

namespace WebStore.MVC.Models
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }


    }
}
