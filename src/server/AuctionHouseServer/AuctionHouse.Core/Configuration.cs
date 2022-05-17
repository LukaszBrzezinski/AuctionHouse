using Microsoft.Extensions.DependencyInjection;

namespace AuctionHouse.Core
{
    public static class Configuration
    {
        public static IServiceCollection RegisterCoreDependencies(this IServiceCollection services)
        {
            services.AddTransient<IAuthService, AuthService>();

            return services;
        }
    }
}
