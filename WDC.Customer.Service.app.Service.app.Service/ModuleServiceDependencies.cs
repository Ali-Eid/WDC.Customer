using Microsoft.Extensions.DependencyInjection;
using WDC.Customers.Service.CustomerServices;

namespace WDC.Customers.Service;

public static class ModuleServiceDependencies
{
    public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
    {
        services.AddTransient<ICustomerService, CustomerService>();

        return services;
    }
}