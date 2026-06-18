using Microsoft.AspNetCore.Mvc;
using BarberApp.Application.Interfaces.Services;

namespace BarberApp.API.Controllers
{
    [ApiController]
    [Route("api/location")]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;
        private readonly ILogger<LocationController> _logger;

        public LocationController(
            ILocationService locationService,
            ILogger<LocationController> logger)
        {
            _locationService = locationService;
            _logger = logger;
        }

        [HttpGet("districts")]
        public async Task<IActionResult> GetDistricts()
        {
            var districts = await _locationService.GetDistrictsAsync();
            return Ok(districts);
        }

        [HttpGet("thanas/{districtId}")]
        public async Task<IActionResult> GetThanas(int districtId)
        {
            var thanas = await _locationService.GetThanasByDistrictAsync(districtId);
            return Ok(thanas);
        }

        [HttpGet("areas/{thanaId}")]
        public async Task<IActionResult> GetAreas(int thanaId)
        {
            var areas = await _locationService.GetAreasByThanaAsync(thanaId);
            return Ok(areas);
        }
    }
}