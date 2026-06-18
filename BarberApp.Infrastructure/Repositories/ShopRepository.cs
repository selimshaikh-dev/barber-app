using BarberApp.Application.Interfaces.Repositories;
using BarberApp.Domain.Entities;
using BarberApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BarberApp.Infrastructure.Repositories
{
    public class ShopRepository : GenericRepository<Shop>, IShopRepository
    {
        public ShopRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Shop>> GetShopsByAreaAsync(int areaId)
        {
            return await _dbSet
                .Where(x => x.AreaId == areaId && x.IsActive)
                .OrderBy(x => x.ShopName)
                .ToListAsync();
        }

        public async Task<IEnumerable<Shop>> GetVerifiedShopsAsync()
        {
            return await _dbSet
                .Where(x => x.IsVerified && x.IsActive)
                .OrderBy(x => x.ShopName)
                .ToListAsync();
        }

        public async Task<IEnumerable<Shop>> SearchShopsAsync(string keyword)
        {
            return await _dbSet
                .Where(x =>
                    x.IsActive &&
                    x.ShopName.Contains(keyword))
                .OrderBy(x => x.ShopName)
                .ToListAsync();
        }

        public async Task<Shop?> GetShopWithDetailsAsync(int shopId)
        {
            return await _dbSet
                .Include(x => x.Owner)
                .Include(x => x.Area)
                    .ThenInclude(x => x.Thana)
                        .ThenInclude(x => x.District)
                .FirstOrDefaultAsync(x =>
                    x.Id == shopId &&
                    x.IsActive);
        }
    }
}