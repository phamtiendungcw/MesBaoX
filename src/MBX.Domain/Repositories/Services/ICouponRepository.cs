using MBX.Domain.Entities.Promotions;

namespace MBX.Domain.Repositories.Services;

public interface ICouponRepository : IGenericRepository<Coupon>
{
    Task<Coupon?> GetCouponByCodeAsync(string couponCode);
    Task<IReadOnlyList<Coupon>> GetActiveCouponsAsync();
    Task<IReadOnlyList<Coupon>> GetExpiredCouponsAsync();
}