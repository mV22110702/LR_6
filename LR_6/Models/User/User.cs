using System.ComponentModel.DataAnnotations;

namespace LR_6.Models.User
{
    public class User
    {
        [Required(ErrorMessage = "User's name is required")]
        [MinLength(2, ErrorMessage = "User's name must have at least 2 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "User's age is required")]
        [Range(minimum: 1, maximum: int.MaxValue)]
        public int Age { get; set; }
    }
}
