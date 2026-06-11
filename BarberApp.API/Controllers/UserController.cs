using Microsoft.AspNetCore.Mvc;

namespace BarberApp.API.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
