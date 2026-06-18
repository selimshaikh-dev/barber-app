using BarberApp.Application.Interfaces.Repositories;
using BarberApp.Application.Interfaces.UnitOfWork;
using BarberApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore.Storage;

namespace BarberApp.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IAsyncDisposable
    {
        private readonly AppDbContext _context;
        private IDbContextTransaction? _transaction;

        public IUserRepository Users { get; }
        public IShopRepository Shops { get; }
        public IBookingRepository Bookings { get; }
        public IDistrictRepository Districts { get; }
        public IThanaRepository Thanas { get; }
        public IAreaRepository Areas { get; }

        public UnitOfWork(
            AppDbContext context,
            IUserRepository userRepository,
            IShopRepository shopRepository,
            IBookingRepository bookingRepository,
            IDistrictRepository districtRepository,
            IThanaRepository thanaRepository,
            IAreaRepository areaRepository)
        {
            _context = context;

            Users = userRepository;
            Shops = shopRepository;
            Bookings = bookingRepository;
            Districts = districtRepository;
            Thanas = thanaRepository;
            Areas = areaRepository;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task BeginTransactionAsync()
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            if (_transaction != null)
            {
                await _transaction.CommitAsync();
            }
        }

        public async Task RollbackTransactionAsync()
        {
            if (_transaction != null)
            {
                await _transaction.RollbackAsync();
            }
        }

        public async ValueTask DisposeAsync()
        {
            if (_transaction != null)
            {
                await _transaction.DisposeAsync();
                _transaction = null;
            }

            await _context.DisposeAsync();
        }
    }
}