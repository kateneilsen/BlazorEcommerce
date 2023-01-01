using BlazorEcommerce.Server.Migrations;

namespace BlazorEcommerce.Server.Services.CategoryService;

public interface ICategoryService
{
    Task<ServiceResponse<List<Category>>> GetCategories();
}