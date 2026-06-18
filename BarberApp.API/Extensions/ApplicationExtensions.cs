using BarberApp.Application.Interfaces.Services;
using BarberApp.Application.Services;

namespace BarberApp.API.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IBookingService, BookingService>();
            services.AddScoped<IJwtService, JwtService>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<IPasswordHasherService, PasswordHasherService>();
            services.AddScoped<IShopService, ShopService>();
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}