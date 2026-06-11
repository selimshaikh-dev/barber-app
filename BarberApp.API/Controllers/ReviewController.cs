using Microsoft.AspNetCore.Mvc;

namespace BarberApp.API.Controllers
{
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
