namespace WebShopPIN.Client.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private HttpClient _http;

        public ProductService(HttpClient http) 
        {
            _http = http;
        }
        public List<Product> Products { get; set; } = new List<Product>();

        public event Action ProductsChanged;

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{productId}");
            return result;
        }

        public async Task GetProducts(string? brandUrl = null)
        {
            var result = brandUrl == null ?
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/product") :
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/product/brand/{brandUrl}");
            if (result != null && result.Data != null)
                Products = result.Data;

           ProductsChanged.Invoke();
        }
    }
}
