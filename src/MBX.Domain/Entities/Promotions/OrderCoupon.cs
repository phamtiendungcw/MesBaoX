using MBX.Domain.Entities.Orders;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities.Promotions;

public class OrderCoupon : BaseEntity
{
    [Required] public Guid OrderId { get; set; } // ID đơn hàng (khóa ngoại đến bảng Order, bắt buộc)
    public virtual Order Order { get; set; } = null!; // Navigation property cho đơn hàng (bắt buộc)
    [Required] public Guid CouponId { get; set; } // ID mã giảm giá (khóa ngoại đến bảng Coupon, bắt buộc)
    public virtual Coupon Coupon { get; set; } = null!; // Navigation property cho mã giảm giá (bắt buộc)
    public DateTime UsedDate { get; set; } = DateTime.UtcNow; // Thời điểm sử dụng mã giảm giá trong đơn hàng
    [Column(TypeName = "decimal(18, 2)")] public decimal AppliedDiscountAmount { get; set; } // Giá trị giảm giá thực tế được áp dụng trong đơn hàng (nếu cần khác DiscountValue gốc của Coupon)
}