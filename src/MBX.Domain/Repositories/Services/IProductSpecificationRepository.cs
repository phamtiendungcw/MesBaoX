using MBX.Domain.Entities.Products;

namespace MBX.Domain.Repositories.Services;

public interface IProductSpecificationRepository : IGenericRepository<ProductSpecification>
{
    Task<IReadOnlyList<ProductSpecification>> GetSpecificationsForProductAsync(Guid productId);
    Task<ProductSpecification?> GetSpecificationByNameForProductAsync(Guid productId, string specificationName);
}