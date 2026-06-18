using BarberApp.Application.DTOs.LocationDtos;

namespace BarberApp.Application.Interfaces.Services
{
    public interface ILocationService 
    {
        Task<List<DistrictDto>> GetDistrictsAsync();
        Task<List<ThanaDto>> GetThanasByDistrictAsync(int districtId);
        Task<List<AreaDto>> GetAreasByThanaAsync(int thanaId);
    }
}