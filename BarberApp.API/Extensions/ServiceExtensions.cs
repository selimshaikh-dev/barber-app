namespace BarberApp.API.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddProjectServices(
            this IServiceCollection services,
            IConfiguration config)
        {
            services
                .AddDatabase(config)
                .AddRepositories()
                .AddApplicationServices()
                .AddJwtAuthentication(config)
                .AddAuthorizationServices(); 

            return services;
        }
    }
}