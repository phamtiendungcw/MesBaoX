namespace MBX.Application.Features.Promotions.DTOs;

public class OrderCouponDto
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid CouponId { get; set; }
    public bool IsActive { get; set; }
}