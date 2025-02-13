namespace MBX.Application.Features.Promotions.DTOs
{
    public class PromotionDto
    {
        public Guid Id { get; set; }
        public string PromotionName { get; set; } = string.Empty;
        public string PromotionType { get; set; } = string.Empty;
        public decimal DiscountValue { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
