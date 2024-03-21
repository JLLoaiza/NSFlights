using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Sales.BLL.Services.Interfaces;
using Sales.BLL.Services;

namespace Sales.IOC
{
    public static class Dependency
    {
        public static void InjectDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMemoryCache();

            services.AddScoped<IJourneyService, JourneyService>(options => new JourneyService(configuration.GetConnectionString("JourneyHost")));
        }
    }
}
