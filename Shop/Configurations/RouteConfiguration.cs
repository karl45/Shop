using Microsoft.AspNetCore.Mvc;
using Shop.Services.Stock.GetAllProducts;

namespace Shop.Configurations;

public class RouteConfiguration
{
    public void ConfigureRoutes(WebApplication application)
    {
        var shop = application.MapGroup("/shop");
        
        shop.MapGet("/", GetProducts);
    }

    private async Task<IResult> GetProducts(IGetAllProductsService getAllProductsService)
    {
        return Results.Ok(await getAllProductsService.GetAllProducts());
    }
    
}