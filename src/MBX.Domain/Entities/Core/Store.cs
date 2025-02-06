using MBX.Domain.Common;

namespace MBX.Domain.Entities.Core;

public class Store : BaseEntity
{
    public Guid CompanyId { get; set; } // ID công ty
    public Company Company { get; set; } = null!; // Công ty mà cửa hàng thuộc về (Navigation)
    public string Name { get; set; } = string.Empty; // Tên cửa hàng - Non-nullable, default to empty string
    public string Address { get; set; } = string.Empty; // Địa chỉ cửa hàng - Non-nullable, default to empty string
    public string PhoneNumber { get; set; } = string.Empty; // Số điện thoại cửa hàng - Non-nullable, default to empty string
    public string? Email { get; set; } // Email cửa hàng (tùy chọn) - Nullable
    public string? ContactPerson { get; set; } // Người liên hệ (tùy chọn) - Nullable
    public string? StoreCode { get; set; } // Mã cửa hàng (tùy chọn) - Nullable
    public string? Description { get; set; } // Mô tả cửa hàng (tùy chọn) - Nullable
    public string? MapCoordinates { get; set; } // Tọa độ bản đồ (tùy chọn) - Nullable
    public string StoreType { get; set; } = string.Empty; // Loại cửa hàng - Non-nullable, default to empty string (Consider enum default if applicable)
    public ICollection<Inventory.Inventory> Inventories { get; set; } = new List<Inventory.Inventory>(); // Danh sách Inventories (Navigation)
    public ICollection<User> Employees { get; set; } = new List<User>(); // Danh sách Employees (Navigation)
    public ICollection<Order.Order> Orders { get; set; } = new List<Order.Order>(); // Danh sách Orders (Navigation)
}