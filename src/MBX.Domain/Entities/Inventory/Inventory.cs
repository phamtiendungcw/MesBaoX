using MBX.Domain.Common;
using MBX.Domain.Entities.Product;

namespace MBX.Domain.Entities.Inventory;

public class Inventory : BaseEntity
{
    public int Quantity { get; set; } // Số lượng tồn kho
    public DateTime LastUpdated { get; set; } = DateTime.UtcNow; // Lần cập nhật cuối (mặc định UTC now)
    public int ReorderLevel { get; set; } // Mức tái đặt hàng
    public int QuantityOnHand { get; set; } // Số lượng hiện có
    public int QuantityAvailable { get; set; } // Số lượng có thể bán
    public string? LocationInWarehouse { get; set; } // Vị trí trong kho (tùy chọn) - Nullable
    public string? BatchNumber { get; set; } // Số lô hàng (tùy chọn) - Nullable
    public DateTime? ExpiryDate { get; set; } // Ngày hết hạn (tùy chọn) - Nullable
    public Guid ProductId { get; set; } // ID sản phẩm
    public Product.Product Product { get; set; } = null!; // Sản phẩm (Navigation)
    public Guid WarehouseId { get; set; } // ID kho hàng
    public Warehouse Warehouse { get; set; } = null!; // Kho hàng (Navigation)
}