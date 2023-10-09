using LR_6.Models.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace LR_6.Models.Order
{
    public class Order
    {
        [Required(ErrorMessage ="User is required for the order")]
        public LR_6.Models.User.User User { get; set; } = new LR_6.Models.User.User();

        [MinLength(1, ErrorMessage = "There must be at least 1 ordered product")]
        public List<OrderedProduct> OrderedProducts { get; set; } = new List<OrderedProduct>();

    }
}
