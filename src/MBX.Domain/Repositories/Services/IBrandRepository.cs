using MBX.Domain.Entities.Products;

namespace MBX.Domain.Repositories.Services;

public interface IBrandRepository : IGenericRepository<Brand>
{
    Task<Brand?> GetBrandBySlugAsync(string slug);
    Task<IReadOnlyList<Brand>> GetActiveBrandsAsync();
}