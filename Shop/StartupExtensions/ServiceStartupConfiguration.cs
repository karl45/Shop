using Shop.Services.Stock.GetAllProducts;

namespace Shop.StartupExtensions;

public static class ServiceStartupConfiguration
{
    public static IServiceCollection ConfigureServices(this IServiceCollection  services)
    {
        services.AddScoped<IGetAllProductsService, GetAllProductsService>();
        return services;
    }
}