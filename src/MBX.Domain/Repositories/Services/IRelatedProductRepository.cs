using MBX.Domain.Entities.Products;

namespace MBX.Domain.Repositories.Services;

public interface IRelatedProductRepository : IGenericRepository<RelatedProduct>
{
    Task<IReadOnlyList<RelatedProduct>> GetRelatedProductsForProductAsync(Guid productId);
    Task<IReadOnlyList<RelatedProduct>> GetRelatedProductsByTypeAsync(string relationType);
}