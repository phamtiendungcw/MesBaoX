using MBX.Domain.Common;
using MBX.Domain.Entities.Product;

namespace MBX.Domain.Entities.Support;

public class Promotion : BaseEntity
{
    public string Code { get; set; } = string.Empty; // Mã khuyến mãi - Non-nullable, default to empty string
    public string Name { get; set; } = string.Empty; // Tên khuyến mãi - Non-nullable, default to empty string
    public string? Description { get; set; } // Mô tả khuyến mãi (tùy chọn) - Nullable
    public decimal DiscountPercentage { get; set; } // Phần trăm chiết khấu
    public decimal? DiscountAmount { get; set; } // Số tiền chiết khấu cố định (tùy chọn) - Nullable
    public DateTime StartDate { get; set; } // Ngày bắt đầu khuyến mãi
    public DateTime EndDate { get; set; } // Ngày kết thúc khuyến mãi
    public string PromotionType { get; set; } = string.Empty; // Loại khuyến mãi - Non-nullable, default to empty string (Consider enum default if applicable)
    public int Priority { get; set; } // Độ ưu tiên khuyến mãi
    public int UsageCount { get; set; } // Số lần đã sử dụng
    public int MaxUsageCount { get; set; } // Số lần sử dụng tối đa
    public decimal MinimumOrderValue { get; set; } // Giá trị đơn hàng tối thiểu để áp dụng khuyến mãi
    public string? TermsAndConditions { get; set; } // Điều khoản và điều kiện (tùy chọn) - Nullable
    public Guid? ProductId { get; set; } // ID sản phẩm (tùy chọn)
    public Product.Product? Product { get; set; } // Sản phẩm (Navigation)
    public Guid? CategoryId { get; set; } // ID danh mục (tùy chọn)
    public Category? Category { get; set; } // Danh mục (Navigation)
}