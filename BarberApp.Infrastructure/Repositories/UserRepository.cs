using BarberApp.Application.Interfaces.Repositories;
using BarberApp.Domain.Entities;
using BarberApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BarberApp.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context)
            : base(context)
        {
        }

        public async Task<bool> ExistsByMobileAsync(string mobileNumber)
        {
            return await _dbSet.AnyAsync(x => x.MobileNumber == mobileNumber);
        }

        public async Task<User?> GetByMobileAsync(string mobileNumber)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.MobileNumber == mobileNumber);
        }
    }
}