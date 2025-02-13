namespace MBX.Application.Features.Promotions.DTOs;

public class PromotionRuleDto
{
    public Guid Id { get; set; }
    public Guid PromotionId { get; set; }
    public string RuleType { get; set; } = string.Empty;
    public string RuleValue { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}