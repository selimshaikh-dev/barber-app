using Microsoft.AspNetCore.Mvc;

namespace BarberApp.API.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
