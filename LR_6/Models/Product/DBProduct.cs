using System.ComponentModel.DataAnnotations;

namespace LR_6.Models.Product
{
    public class DBProduct : BaseProduct
    {
        [Required(ErrorMessage = "Product's name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Product's price is required")]
        public double Price { get; set; }

        public DBProduct() : base() { }
    }
}
