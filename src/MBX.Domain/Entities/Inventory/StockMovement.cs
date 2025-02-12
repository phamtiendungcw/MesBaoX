using MBX.Domain.Entities.Products;

using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Inventory;

public class StockMovement : BaseEntity
{
    [Required]
    public Guid ProductId { get; set; } // ID sản phẩm (khóa ngoại đến bảng Product, bắt buộc)

    public virtual Product Product { get; set; } = null!; // Navigation property cho sản phẩm (bắt buộc)
    public Guid? ProductVariantId { get; set; } // ID biến thể sản phẩm (khóa ngoại đến bảng ProductVariant, có thể null nếu không phải biến thể)
    public virtual ProductVariant? ProductVariant { get; set; } // Navigation property cho biến thể sản phẩm (có thể null)

    [Required]
    public Guid WarehouseId { get; set; } // ID kho hàng (khóa ngoại đến bảng Warehouse, bắt buộc)

    public virtual Warehouse Warehouse { get; set; } = null!; // Navigation property cho kho hàng (bắt buộc)

    [Required]
    [MaxLength(50)]
    public string MovementType { get; set; } = string.Empty; // Loại nhập/xuất kho (ví dụ: "Inbound", "Outbound", "Adjustment") (bắt buộc, độ dài tối đa 50 ký tự)

    public int Quantity { get; set; } // Số lượng thay đổi tồn kho (bắt buộc)
    public DateTime MovementDate { get; set; } = DateTime.UtcNow; // Ngày nhập/xuất kho (mặc định UTC now)

    [MaxLength(255)]
    public string? ReferenceDocument { get; set; } // Tài liệu tham khảo (ví dụ: Mã phiếu nhập kho, Mã đơn hàng) (không bắt buộc, độ dài tối đa 255 ký tự)

    [MaxLength(4000)]
    public string? Description { get; set; } // Mô tả nhập/xuất kho (không bắt buộc, độ dài tối đa 4000 ký tự)
}