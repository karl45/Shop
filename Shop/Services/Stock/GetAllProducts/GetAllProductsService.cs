using Shop.Models;

namespace Shop.Services.Stock.GetAllProducts;

public class GetAllProductsService : IGetAllProductsService
{
    public Task<IEnumerable<Product>> GetAllProducts()
    {
        return Task.FromResult<IEnumerable<Product>>(new List<Product>());
    }
    
}