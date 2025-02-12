using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Promotions;

public class PromotionRule : BaseEntity
{
    [Required]
    public Guid PromotionId { get; set; } // ID khuyến mãi (khóa ngoại đến bảng Promotion, bắt buộc)

    public virtual Promotion Promotion { get; set; } = null!; // Navigation property cho khuyến mãi (bắt buộc)

    [Required]
    [MaxLength(255)]
    public string RuleType { get; set; } = string.Empty; // Loại quy tắc (ví dụ: "CartTotal", "Category", "CustomerGroup") (bắt buộc, độ dài tối đa 255 ký tự)

    [Required]
    [MaxLength(4000)]
    public string RuleValue { get; set; } = string.Empty; // Giá trị quy tắc (ví dụ: ">=1000000", "CategoryId=5", "CustomerGroupId=2") (bắt buộc, độ dài tối đa 4000 ký tự, tùy thuộc vào loại quy tắc)
}