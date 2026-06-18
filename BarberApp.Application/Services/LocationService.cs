using BarberApp.Application.DTOs.LocationDtos;
using BarberApp.Application.Interfaces.Services;
using BarberApp.Application.Interfaces.UnitOfWork;

namespace BarberApp.Application.Services
{
    public class LocationService : ILocationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LocationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<DistrictDto>> GetDistrictsAsync()
        {
            var districts = await _unitOfWork.Districts.GetAllAsync();

            return districts
                .OrderBy(x => x.Name)
                .Select(x => new DistrictDto
                {
                    Id = x.Id,
                    Name = x.Name
                })
                .ToList();
        }


        public async Task<List<ThanaDto>> GetThanasByDistrictAsync(int districtId)
        {
            if (districtId <= 0)
                throw new Exception("Invalid district id");

            var thanas = await _unitOfWork.Thanas
                .FindAsync(x => x.DistrictId == districtId);

            return thanas
                .OrderBy(x => x.Name)
                .Select(x => new ThanaDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    DistrictId = x.DistrictId
                })
                .ToList();
        }


        public async Task<List<AreaDto>> GetAreasByThanaAsync(int thanaId)
        {
            if (thanaId <= 0)
                throw new Exception("Invalid thana id");

            var areas = await _unitOfWork.Areas
                .FindAsync(x => x.ThanaId == thanaId);

            return areas
                .OrderBy(x => x.Name)
                .Select(x => new AreaDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    ThanaId = x.ThanaId,
                    Latitude = x.Latitude,
                    Longitude = x.Longitude
                })
                .ToList();
        }
    }
}