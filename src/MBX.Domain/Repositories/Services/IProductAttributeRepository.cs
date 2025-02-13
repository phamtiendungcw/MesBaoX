using MBX.Domain.Entities.Products;

namespace MBX.Domain.Repositories.Services;

public interface IProductAttributeRepository : IGenericRepository<ProductAttribute>
{
    Task<ProductAttribute?> GetProductAttributeByNameAsync(string attributeName);
    Task<IReadOnlyList<ProductAttribute>> GetProductAttributesByCategoryAsync(Guid categoryId);
}