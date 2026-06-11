using Microsoft.AspNetCore.Mvc;

namespace BarberApp.API.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
