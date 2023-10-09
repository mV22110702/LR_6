using System.ComponentModel.DataAnnotations;

namespace LR_6.Models.Product
{
    public class BaseProduct
    {
        [Required(ErrorMessage = "Product's id is required")]
        public int Id { get; set; }

        public BaseProduct() { }
    }
}
