using Microsoft.AspNetCore.Mvc;

namespace Shoe.Services.ShoppingCartAPI.Controllers
{
    [ApiController]
    [Route("api/cart")]
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
