using LR_6.Models.Order;
using LR_6.Models.Product;
using LR_6.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LR_6.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : Controller
    {
        private static DBProduct AppleJuice = new DBProduct() { Id = 0, Name = "Apple juice", Price = 25.3 };
        private static DBProduct OrangeJuice = new DBProduct() { Id = 1, Name = "Orange juice", Price = 21.2 };
        private static DBProduct PineapplePizza = new DBProduct() { Id = 2, Name = "Pineapple pizza", Price = 115.2 };
        private static DBProduct MeatPizza = new DBProduct() { Id = 3, Name = "Meat pizza", Price = 345.7 };
        private static DBProduct VegetablePizza = new DBProduct() { Id = 4, Name = "Vegetable pizza", Price = 158.8 };
        private static List<DBProduct> AvailableProductsMock = new List<DBProduct>() {
                AppleJuice,
                OrangeJuice,
                PineapplePizza,
                MeatPizza,
                VegetablePizza
        };

        private string AgeErrorMessage = "You must be at least 17 years old to create an order";

        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("/order-details")]
        public ViewResult OrderDetails([FromForm] OrderFirstStageRequestDto orderFirstStageRequestDto)
        {
            if (orderFirstStageRequestDto.User.Age <= 16)
            {
                return View("Views/Home/Error.cshtml", new Error() { Message = AgeErrorMessage });
            }
            var orderSecondStageInitialDto = new OrderSecondStageInitialDto()
            {
                AvailableProducts = HomeController.AvailableProductsMock,
                FirstStageOrderData = orderFirstStageRequestDto
            };

            return View("Views/Home/OrderDetails.cshtml", orderSecondStageInitialDto);
        }

        [HttpPost("/order-result")]
        public ViewResult OrderResult([FromForm] Order order)
        {
            if (order.User.Age <= 16)
            {
                return View("Views/Home/Error.cshtml", new Error() { Message = AgeErrorMessage });
            }
            return View("Views/Home/OrderResult.cshtml", order);
        }
    }
}
