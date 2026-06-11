using Microsoft.AspNetCore.Mvc;

namespace BarberApp.API.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
