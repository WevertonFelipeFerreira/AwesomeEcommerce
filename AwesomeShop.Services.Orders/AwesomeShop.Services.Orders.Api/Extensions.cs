using AwesomeShop.Services.Orders.Core.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AwesomeShop.Services.Orders.Api
{
    public static class Extensions
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IOrderRepository, OrderRepository>();

            return services;
        }
    }
}
