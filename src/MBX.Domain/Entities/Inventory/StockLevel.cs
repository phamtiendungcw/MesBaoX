using MBX.Domain.Entities.Products;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MBX.Domain.Entities.Inventory;

public class StockLevel : BaseEntity
{
    [Required]
    public Guid ProductId { get; set; } // ID sản phẩm (khóa ngoại đến bảng Product, bắt buộc)

    public virtual Product Product { get; set; } = null!; // Navigation property cho sản phẩm (bắt buộc)
    public Guid? ProductVariantId { get; set; } // ID biến thể sản phẩm (khóa ngoại đến bảng ProductVariant, có thể null nếu không phải biến thể)
    public virtual ProductVariant? ProductVariant { get; set; } // Navigation property cho biến thể sản phẩm (có thể null)

    [Required]
    public Guid WarehouseId { get; set; } // ID kho hàng (khóa ngoại đến bảng Warehouse, bắt buộc)

    public virtual Warehouse Warehouse { get; set; } = null!; // Navigation property cho kho hàng (bắt buộc)
    public int QuantityOnHand { get; set; } // Số lượng tồn kho hiện tại (bắt buộc)
    public int QuantityAllocated { get; set; } // Số lượng đã phân bổ (cho các đơn hàng chưa giao) (bắt buộc)

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)] // Thuộc tính Calculated - giá trị được tính toán bởi database
    public int QuantityAvailable { get; set; } // Số lượng có sẵn (tính toán: QuantityOnHand - QuantityAllocated) (tự động tính toán)

    public int? ReorderPoint { get; set; } // Điểm đặt hàng lại (không bắt buộc, khi tồn kho xuống dưới mức này thì cần đặt hàng)
    public int? MaximumStockLevel { get; set; } // Mức tồn kho tối đa (không bắt buộc)
}