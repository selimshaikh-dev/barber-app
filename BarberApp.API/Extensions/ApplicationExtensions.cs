namespace BarberApp.API.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // BUSINESS LAYER SERVICES (later)

            // services.AddScoped<IAuthService, AuthService>();
            // services.AddScoped<IUserService, UserService>();
            // services.AddScoped<IShopService, ShopService>();
            // services.AddScoped<IBookingService, BookingService>();
            // services.AddScoped<IPaymentService, PaymentService>();

            return services;
        }
    }
}