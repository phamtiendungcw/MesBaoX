using MBX.Domain.Entities.Products;

namespace MBX.Domain.Repositories.Services;

public interface IProductTagRepository : IGenericRepository<ProductTag>
{
    Task<ProductTag?> GetProductTagByNameAsync(string tagName);
    Task<IReadOnlyList<ProductTag>> GetPopularProductTagsAsync(int count);
    Task<IReadOnlyList<ProductTag>> GetTagsForProductAsync(Guid productId);
}