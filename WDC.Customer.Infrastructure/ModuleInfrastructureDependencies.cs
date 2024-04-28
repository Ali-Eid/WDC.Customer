using Microsoft.Extensions.DependencyInjection;
using WDC.Customers.Infrastructure.Bases.RepositoryBase;

namespace WDC.Customers.Infrastructure;

public static class ModuleInfrastructureDependencies
{
    public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
    {
        services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));

        return services;
    }
}

