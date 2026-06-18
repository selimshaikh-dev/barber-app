using BarberApp.Domain.Entities;

namespace BarberApp.Application.Interfaces.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<bool> ExistsByMobileAsync(string mobileNumber);

        Task<User?> GetByMobileAsync(string mobileNumber);
    }
}