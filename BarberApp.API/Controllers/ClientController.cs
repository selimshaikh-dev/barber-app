using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BarberApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Policy = "ClientOnly")]
    public class ClientController : ControllerBase
    {
        [HttpPost("booking")]
        public IActionResult CreateBooking()
        {
            return Ok("Booking created");
        }

        [HttpGet("my-bookings")]
        public IActionResult MyBookings()
        {
            return Ok("Client booking history");
        }

        [HttpPost("payment")]
        public IActionResult Pay()
        {
            return Ok("Payment completed");
        }
    }
}
