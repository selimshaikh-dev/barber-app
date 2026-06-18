using BarberApp.Application.Interfaces.Repositories;

namespace BarberApp.Application.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IUserRepository Users { get; }
        IShopRepository Shops { get; }
        IBookingRepository Bookings { get; }
        IDistrictRepository Districts { get; }
        IThanaRepository Thanas { get; }
        IAreaRepository Areas { get; }
        Task<int> SaveChangesAsync();
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
    }
}