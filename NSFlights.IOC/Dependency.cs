using Microsoft.Extensions.DependencyInjection;

namespace Sales.IOC
{
    public static class Dependency
    {
        public static void InjectDependencies(this IServiceCollection services)
        {
            services.AddMemoryCache();
        }
    }
}
