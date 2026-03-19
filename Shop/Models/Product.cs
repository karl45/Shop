namespace Shop.Models;

public class Product
{
    public Guid Id { init; get; }
    
    public string ProductName { init; get; }
    
    public decimal Price { init; get; }
    
    public int Count { init; get; }
}