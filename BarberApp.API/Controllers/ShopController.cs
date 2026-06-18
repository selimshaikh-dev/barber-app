using BarberApp.Application.DTOs;
using BarberApp.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace BarberApp.API.Controllers
{
    [ApiController]
    [Route("api/shops")]
    public class ShopController : ControllerBase
    {
        private readonly IShopService _shopService;
        private readonly ILogger<ShopController> _logger;

        public ShopController(
            IShopService shopService,
            ILogger<ShopController> logger)
        {
            _shopService = shopService;
            _logger = logger;
        }

        [HttpGet("by-area/{areaId}")]
        public async Task<IActionResult> GetShopsByArea(int areaId)
        {
            var shops = await _shopService.GetShopsByAreaAsync(areaId);

            if (!shops.Any())
            {
                return Ok(new
                {
                    message = "No Shop Found",
                    data = new List<ShopDto>()
                });
            }

            return Ok(new
            {
                message = "Success",
                data = shops
            });
        }
    }
}