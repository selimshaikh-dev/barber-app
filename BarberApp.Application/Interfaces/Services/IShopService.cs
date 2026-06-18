using BarberApp.Application.DTOs;

namespace BarberApp.Application.Interfaces.Services
{
    public interface IShopService
    {
        Task<List<ShopDto>> GetShopsByAreaAsync(int areaId);
    }
}