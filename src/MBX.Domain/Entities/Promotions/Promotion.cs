using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities.Promotions;

public class Promotion : BaseEntity
{
    [Required]
    [MaxLength(255)]
    public string PromotionName { get; set; } = string.Empty; // Tên khuyến mãi (ví dụ: "Giảm giá 20%", "Miễn phí vận chuyển") (bắt buộc, độ dài tối đa 255 ký tự)

    [MaxLength(4000)]
    public string? Description { get; set; } // Mô tả khuyến mãi (không bắt buộc, độ dài tối đa 4000 ký tự)

    [Required]
    [MaxLength(50)]
    public string PromotionType { get; set; } = string.Empty; // Loại khuyến mãi (ví dụ: "PercentageDiscount", "FixedAmountDiscount", "FreeShipping") (bắt buộc, độ dài tối đa 50 ký tự)

    [Column(TypeName = "decimal(18, 2)")]
    public decimal DiscountValue { get; set; } // Giá trị giảm giá (bắt buộc, kiểu decimal với 2 số thập phân, tùy thuộc vào loại khuyến mãi)

    public DateTime? StartDate { get; set; } // Ngày bắt đầu khuyến mãi (không bắt buộc)
    public DateTime? EndDate { get; set; } // Ngày kết thúc khuyến mãi (không bắt buộc)

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MinimumOrderAmount { get; set; } // Giá trị đơn hàng tối thiểu để áp dụng khuyến mãi (không bắt buộc, kiểu decimal với 2 số thập phân)

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MaximumDiscountAmount { get; set; } // Số tiền giảm giá tối đa (cho khuyến mãi phần trăm) (không bắt buộc, kiểu decimal với 2 số thập phân)

    public virtual ICollection<Coupon> Coupons { get; set; } = new List<Coupon>(); // Navigation property cho mã giảm giá (danh sách các mã giảm giá liên kết với khuyến mãi này)
    public virtual ICollection<PromotionRule> PromotionRules { get; set; } = new List<PromotionRule>(); // Navigation property cho quy tắc khuyến mãi (danh sách các quy tắc áp dụng cho khuyến mãi này)
}