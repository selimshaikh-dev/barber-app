using BarberApp.Application.Interfaces;
using BarberApp.Infrastructure.Repositories;

namespace BarberApp.API.Extensions
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // later you can add:
            // services.AddScoped<IUserRepository, UserRepository>();
            // services.AddScoped<IShopRepository, ShopRepository>();
            // services.AddScoped<IBookingRepository, BookingRepository>();

            return services;
        }
    }
}