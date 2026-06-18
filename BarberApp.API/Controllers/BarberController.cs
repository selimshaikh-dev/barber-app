using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BarberApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Policy = "BarberOnly")]
    public class BarberController : ControllerBase
    {
        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            return Ok("Welcome Barber Dashboard");
        }

        [HttpGet("appointments")]
        public IActionResult GetRequests()
        {
            return Ok("Pending booking requests");
        }

        [HttpPut("booking/{id}/approve")]
        public IActionResult Approve(int id)
        {
            return Ok($"Booking {id} approved");
        }

        [HttpPut("booking/{id}/reject")]
        public IActionResult Reject(int id)
        {
            return Ok($"Booking {id} rejected");
        }
    }
}