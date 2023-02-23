namespace WebShopPIN.Server.Services.BrandService
{
    public interface IBrandService
    {
        Task<ServiceResponse<List<Brand>>> GetBrandsAsync();
    }
}
