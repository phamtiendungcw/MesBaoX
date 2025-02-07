using MBX.Domain.Common;
using MBX.Domain.Entities.Core;
using MBX.Domain.Entities.Product;

namespace MBX.Domain.Entities.Sales;

public class Contact : BaseEntity
{
    public Guid CompanyId { get; set; } // ID công ty
    public Company Company { get; set; } = null!; // Công ty mà liên hệ thuộc về (Navigation)
    public string ContactType { get; set; } = string.Empty; // Loại liên hệ - Non-nullable, default to empty string (Consider enum default if applicable)
    public Guid? CustomerId { get; set; } // ID khách hàng (tùy chọn)
    public Customer? Customer { get; set; } // Khách hàng liên quan (Navigation)
    public Guid? SupplierId { get; set; } // ID nhà cung cấp (tùy chọn)
    public Supplier? Supplier { get; set; } // Nhà cung cấp liên quan (Navigation)
    public string FirstName { get; set; } = string.Empty; // Tên liên hệ - Non-nullable, default to empty string
    public string LastName { get; set; } = string.Empty; // Họ liên hệ - Non-nullable, default to empty string
    public string FullName => $"{FirstName} {LastName}"; // Tên đầy đủ (tính toán)
    public string? JobTitle { get; set; } // Chức danh (tùy chọn) - Nullable
    public string? Department { get; set; } // Phòng ban (tùy chọn) - Nullable
    public string Email { get; set; } = string.Empty; // Email liên hệ - Non-nullable, default to empty string
    public string? PhoneNumber { get; set; } // Số điện thoại liên hệ (tùy chọn) - Nullable
    public string? MobileNumber { get; set; } // Số điện thoại di động (tùy chọn) - Nullable
    public string? Address { get; set; } // Địa chỉ liên hệ (tùy chọn) - Nullable
    public string? Notes { get; set; } // Ghi chú liên hệ (tùy chọn) - Nullable
    public string? SocialMediaLinks { get; set; } // Liên kết mạng xã hội (JSON) (tùy chọn) - Nullable
    public bool IsPrimaryContact { get; set; } // Liên hệ chính (true/false)
}