using MBX.Domain.Common;

namespace MBX.Domain.Entities.Product;

public class Warehouse : BaseEntity
{
    public Guid CompanyId { get; set; } // ID công ty
    public Core.Company Company { get; set; } = null!; // Công ty mà kho hàng thuộc về (Navigation)
    public string Name { get; set; } = string.Empty; // Tên kho hàng - Non-nullable, default to empty string
    public string Address { get; set; } = string.Empty; // Địa chỉ kho hàng - Non-nullable, default to empty string
    public string? ContactPerson { get; set; } // Người liên hệ kho (tùy chọn) - Nullable
    public string? PhoneNumber { get; set; } // Số điện thoại kho (tùy chọn) - Nullable
    public string? Email { get; set; } // Email kho (tùy chọn) - Nullable
    public string? WarehouseCode { get; set; } // Mã kho hàng (tùy chọn) - Nullable
    public string WarehouseType { get; set; } = string.Empty; // Loại kho - Non-nullable, default to empty string (Consider enum default if applicable)
    public string? Capacity { get; set; } // Sức chứa kho (tùy chọn) - Nullable
    public Guid? LocationId { get; set; } // ID địa điểm kho (tùy chọn)
    public Core.Location Location { get; set; } = null!; // Địa điểm kho (Navigation)
    public ICollection<Inventory.Inventory> Inventories { get; set; } = new List<Inventory.Inventory>(); // Danh sách Inventories (Navigation)
}