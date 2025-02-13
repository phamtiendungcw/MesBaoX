using MBX.Domain.Entities.Promotions;

namespace MBX.Domain.Repositories.Services;

public interface IPromotionRepository : IGenericRepository<Promotion>
{
    Task<Promotion?> GetPromotionByNameAsync(string promotionName);
    Task<IReadOnlyList<Promotion>> GetActivePromotionsAsync();
    Task<IReadOnlyList<Promotion>> GetPromotionsByTypeAsync(string promotionType);
    Task<IReadOnlyList<Promotion>> GetPromotionsValidOnDateAsync(DateTime date);
}