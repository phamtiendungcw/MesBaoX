using MBX.Domain.Entities.Promotions;

namespace MBX.Domain.Repositories.Services;

public interface IPromotionRuleRepository : IGenericRepository<PromotionRule>
{
    Task<IReadOnlyList<PromotionRule>> GetPromotionRulesByPromotionAsync(Guid promotionId);
    Task<IReadOnlyList<PromotionRule>> GetPromotionRulesByTypeAsync(string ruleType);
}