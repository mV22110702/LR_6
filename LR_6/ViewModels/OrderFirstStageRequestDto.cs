using System.ComponentModel.DataAnnotations;

namespace LR_6.ViewModels
{
    public class OrderFirstStageRequestDto
    {
        [Required(ErrorMessage = "User is required for the order")]
        public Models.User.User User { get; set; } = new Models.User.User();

        [Range(minimum: 1, maximum: int.MaxValue)]
        public int NumOrderedProducts { get; set; }
    }
}
