using MBX.Domain.Entities.Products;

namespace MBX.Domain.Repositories.Services;

public interface ICategoryRepository : IGenericRepository<Category>
{
    Task<Category?> GetCategoryBySlugAsync(string slug);
    Task<IReadOnlyList<Category>> GetCategoriesWithProductsAsync();
    Task<IReadOnlyList<Category>> GetActiveCategoriesAsync();
}