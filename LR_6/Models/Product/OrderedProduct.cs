using System.ComponentModel.DataAnnotations;

namespace LR_6.Models.Product
{
    public class OrderedProduct : DBProduct
    {
        [Required(ErrorMessage = "Ordered product's quantity is required")]
        [Range(minimum: 1, maximum: int.MaxValue)]
        public int Quantity { get; set; }
    }
}
