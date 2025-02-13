using MBX.Domain.Entities.Products;

namespace MBX.Domain.Repositories.Services;

public interface IProductVariantRepository : IGenericRepository<ProductVariant>
{
    Task<ProductVariant?> GetProductVariantBySKUAsync(string sku);
    Task<IReadOnlyList<ProductVariant>> GetProductVariantsForProductAsync(Guid productId);
    Task<IReadOnlyList<ProductVariant>> GetProductVariantsInStockAsync();
}