using Shop.Configurations;

namespace Shop.StartupExtensions;

public static class RouterStartupConfiguration
{
    public static void MapRoutes(this WebApplication app)
    {
        var endPointConfiguration = new RouteConfiguration();
        endPointConfiguration.ConfigureRoutes(app);
    }
}