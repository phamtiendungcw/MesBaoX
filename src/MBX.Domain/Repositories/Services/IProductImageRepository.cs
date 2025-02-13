using MBX.Domain.Entities.Products;

namespace MBX.Domain.Repositories.Services;

public interface IProductImageRepository : IGenericRepository<ProductImage>
{
    Task<IReadOnlyList<ProductImage>> GetProductImagesByProductAsync(Guid productId);
    Task<ProductImage?> GetThumbnailImageForProductAsync(Guid productId);
}