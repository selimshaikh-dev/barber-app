using Microsoft.AspNetCore.Mvc;

namespace BarberApp.API.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
