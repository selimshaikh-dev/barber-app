using BarberApp.Application.DTOs;
using BarberApp.Application.Interfaces.Services;
using BarberApp.Application.Interfaces.UnitOfWork;

namespace BarberApp.Application.Services
{
    public class ShopService : IShopService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ShopService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<ShopDto>> GetShopsByAreaAsync(int areaId)
        {
            if (areaId <= 0)
                throw new Exception("Invalid area id");

            var shops = await _unitOfWork.Shops
                .FindAsync(x => x.AreaId == areaId);

            return shops
                .Select(x => new ShopDto
                {
                    Id = x.Id,
                    ShopName = x.ShopName,
                    Description = x.Description,
                    Address = x.Address,
                    RatingAvg = x.RatingAvg,
                    TotalReviews = x.TotalReviews,
                    IsVerified = x.IsVerified
                })
                .ToList();
        }
    }
}