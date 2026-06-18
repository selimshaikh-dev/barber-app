using BarberApp.Domain.Entities;

namespace BarberApp.Application.Interfaces.Services
{
    public interface IJwtService
    {
        string GenerateToken(User user);
    }
}