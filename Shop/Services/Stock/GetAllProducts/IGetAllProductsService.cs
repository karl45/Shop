using Shop.Models;

namespace Shop.Services.Stock.GetAllProducts
{
    public interface IGetAllProductsService
    {
        Task<IEnumerable<Product>> GetAllProducts();
    }
}