using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.Core.Model.Admin.Order
{
    public class OrderTableModel
    {
        public int Id { get; set; }

        [Display(Name = "Customer")]
        public string CustomerEmail { get; set; } = null!;

        [Display(Name = "Created")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Status")]
        public string OrderStatus { get; set; } = null!;

        [Display(Name = "Total Price")]
        public decimal TotalPrice { get; set; }
    }
}
