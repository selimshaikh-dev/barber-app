using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using BarberApp.Application.Interfaces.Services;

namespace BarberApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Policy = "AdminOnly")]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        //[HttpPost("create-barber")]
        //public async Task<IActionResult> CreateBarber(CreateBarberRequestDto dto)
        //{
        //    var result = await _adminService.CreateBarberAsync(dto);
        //    return Ok(result);
        //}
    }
}