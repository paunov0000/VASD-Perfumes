using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Core.Model.Product
{
    public class ProductRestockViewModel
    {
        [Display(Name = "Product | Quantity")]
        public Guid Id { get; set; }

        [Display(Name = "Restock Count")]
        public int Count { get; set; }
    }
}
