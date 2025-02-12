using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities.Promotions;

public class Coupon : BaseEntity
{
    [Required]
    [MaxLength(255)]
    public string CouponCode { get; set; } = string.Empty; // Mã giảm giá (bắt buộc, độ dài tối đa 255 ký tự, duy nhất trong hệ thống)

    public Guid? PromotionId { get; set; } // ID khuyến mãi liên kết (khóa ngoại đến bảng Promotion, có thể null nếu mã giảm giá không liên kết với khuyến mãi cụ thể)
    public virtual Promotion? Promotion { get; set; } // Navigation property cho khuyến mãi (có thể null)

    [Column(TypeName = "decimal(18, 2)")]
    public decimal DiscountValue { get; set; } // Giá trị giảm giá (bắt buộc, kiểu decimal với 2 số thập phân, tùy thuộc vào loại giảm giá)

    public int? UsageLimit { get; set; } // Số lần sử dụng tối đa (không bắt buộc, null nghĩa là không giới hạn)
    public DateTime? ExpiryDate { get; set; } // Ngày hết hạn mã giảm giá (không bắt buộc)

    #region Navigation properties

    public virtual ICollection<OrderCoupon> OrderCoupons { get; set; } = new List<OrderCoupon>(); // Navigation property cho đơn hàng sử dụng mã giảm giá (quan hệ Many-to-Many, danh sách các đơn hàng đã sử dụng mã giảm giá này)

    #endregion Navigation properties
}