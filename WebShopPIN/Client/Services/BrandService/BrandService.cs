namespace WebShopPIN.Client.Services.BrandService
{
    public class BrandService : IBrandService
    {
        private HttpClient _http;

        public BrandService(HttpClient http)
        {
            _http = http;
        }
        public List<Brand> Brands { get; set; } = new List<Brand>();

        public async Task GetBrandsAsync()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<Brand>>>("api/Brand");
            if( response != null && response.Data != null)
            Brands = response.Data;
        }
    }
}
