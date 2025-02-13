using MBX.Domain.Entities.Products;

namespace MBX.Domain.Repositories.Services;

public interface IProductReviewRepository : IGenericRepository<ProductReview>
{
    Task<IReadOnlyList<ProductReview>> GetApprovedReviewsForProductAsync(Guid productId);
    Task<IReadOnlyList<ProductReview>> GetPendingApprovalReviewsAsync();
    Task<decimal> GetAverageRatingForProductAsync(Guid productId);
}