
namespace WebShopPIN.Client.Services.ProductServices
{
    public interface IProductService
    {
        event Action ProductsChanged;
        List<Product> Products { get; set; }
        Task GetProducts(string? brandUrl = null);
        Task<ServiceResponse<Product>> GetProduct(int productId);
    }
}
