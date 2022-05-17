using AuctionHouse.Core;
using Microsoft.Extensions.DependencyInjection;

namespace AuctionHouse.Infrastructure
{
    public static class Configuration
    {
        public static IServiceCollection RegisterInfrastuctureDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IUserRepository, InMemoryUserRepository>();

            return services;
        }
    }
}
