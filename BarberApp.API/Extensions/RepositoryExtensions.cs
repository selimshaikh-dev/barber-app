using BarberApp.Application.Interfaces.Repositories;
using BarberApp.Application.Interfaces.UnitOfWork;
using BarberApp.Infrastructure.Repositories;
using BarberApp.Infrastructure.UnitOfWork;

namespace BarberApp.API.Extensions
{
    public static class RepositoryExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IShopRepository, ShopRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();

            services.AddScoped<IDistrictRepository, DistrictRepository>();
            services.AddScoped<IThanaRepository, ThanaRepository>();
            services.AddScoped<IAreaRepository, AreaRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}