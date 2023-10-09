using LR_6.Models.Product;

namespace LR_6.ViewModels
{
    public class OrderSecondStageInitialDto
    {
        public OrderFirstStageRequestDto FirstStageOrderData { get; set; } = new OrderFirstStageRequestDto();
        public List<DBProduct> AvailableProducts { get; set; } = new();
    }
}
