namespace MBX.Application.Features.Promotions.DTOs;

public class CouponDto
{
    public Guid Id { get; set; }
    public string CouponCode { get; set; } = string.Empty;
    public decimal DiscountValue { get; set; }
    public bool IsActive { get; set; }
}