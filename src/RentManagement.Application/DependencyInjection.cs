using Microsoft.Extensions.DependencyInjection;
using RentManagement.Application.Services;

namespace RentManagement.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IRentService, RentService>();
            return services;
        }
    }
}
