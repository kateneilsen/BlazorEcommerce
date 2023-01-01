namespace BlazorEcommerce.Client.Services.ProductService;

public interface IProductService
{
    //tell component something has been changed use event and life cycle method
    event Action ProductsChanged;
    List<Product> Products { get; set; }
    Task GetProducts(string? categoryUrl = null);
    Task<ServiceResponse<Product>> GetProduct(int productId);
}