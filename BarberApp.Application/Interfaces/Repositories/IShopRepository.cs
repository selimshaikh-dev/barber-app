using BarberApp.Domain.Entities;

namespace BarberApp.Application.Interfaces.Repositories
{
    public interface IShopRepository : IGenericRepository<Shop>
    {
        Task<IEnumerable<Shop>> GetShopsByAreaAsync(int areaId);

        Task<IEnumerable<Shop>> GetVerifiedShopsAsync();

        Task<IEnumerable<Shop>> SearchShopsAsync(string keyword);

        Task<Shop?> GetShopWithDetailsAsync(int shopId);
    }
}