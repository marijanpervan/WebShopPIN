namespace WebShopPIN.Client.Services.BrandService
{
    public interface IBrandService
    {
        List<Brand> Brands { get; set; }
        Task GetBrandsAsync();
    }
}
