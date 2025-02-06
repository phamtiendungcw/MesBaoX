using MBX.Domain.Common;

namespace MBX.Domain.Entities.Core;

public class Location : BaseEntity
{
    public Guid CompanyId { get; set; } // ID công ty
    public Company Company { get; set; } = null!; // Công ty mà địa điểm thuộc về (Navigation)
    public string LocationName { get; set; } = string.Empty; // Tên địa điểm - Non-nullable, default to empty string
    public string LocationType { get; set; } = string.Empty; // Loại địa điểm - Non-nullable, default to empty string (Consider enum default if applicable)
    public string Address { get; set; } = string.Empty; // Địa chỉ địa điểm - Non-nullable, default to empty string
    public string? PhoneNumber { get; set; } // Số điện thoại địa điểm (tùy chọn) - Nullable
    public string? FaxNumber { get; set; } // Số fax địa điểm (tùy chọn) - Nullable
    public string? ContactEmail { get; set; } // Email liên hệ địa điểm (tùy chọn) - Nullable
    public string? MapCoordinates { get; set; } // Tọa độ bản đồ (tùy chọn) - Nullable
    public ICollection<User> Users { get; set; } = new List<User>(); // Danh sách Users (Navigation)
    public ICollection<Department> Departments { get; set; } = new List<Department>(); // Danh sách Departments (Navigation)
    public ICollection<Inventory.Inventory> Warehouses { get; set; } = new List<Inventory.Inventory>(); // Danh sách Warehouses (Navigation)
}