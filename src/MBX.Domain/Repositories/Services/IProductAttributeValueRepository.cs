using MBX.Domain.Entities.Products;

namespace MBX.Domain.Repositories.Services;

public interface IProductAttributeValueRepository : IGenericRepository<ProductAttributeValue>
{
    Task<IReadOnlyList<ProductAttributeValue>> GetAttributeValuesByAttributeNameAsync(string attributeName);
    Task<IReadOnlyList<ProductAttributeValue>> GetAttributeValuesForProductAsync(Guid productId);
}