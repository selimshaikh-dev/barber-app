using Microsoft.AspNetCore.Authorization;

namespace BarberApp.API.Extensions
{
    public static class AuthorizationExtensions
    {
        public static IServiceCollection AddAuthorizationServices(
            this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminOnly", policy =>
                    policy.RequireRole("Admin"));

                options.AddPolicy("BarberOnly", policy =>
                    policy.RequireRole("Barber"));

                options.AddPolicy("ClientOnly", policy =>
                    policy.RequireRole("Client"));

                options.AddPolicy("AdminOrBarber", policy =>
                    policy.RequireRole("Admin", "Barber"));

                options.AddPolicy("AuthenticatedUser", policy =>
                    policy.RequireAuthenticatedUser());
            });

            return services;
        }
    }
}