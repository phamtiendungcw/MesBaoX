using MBX.Domain.Common;
using MBX.Domain.Entities.Core;

namespace MBX.Domain.Entities.Support;

public class Address : BaseEntity
{
    public string Street { get; set; } = string.Empty; // Đường phố - Non-nullable, default to empty string
    public string City { get; set; } = string.Empty; // Thành phố - Non-nullable, default to empty string
    public string? State { get; set; } // Tiểu bang (tùy chọn) - Nullable
    public string Country { get; set; } = string.Empty; // Quốc gia - Non-nullable, default to empty string
    public string? ZipCode { get; set; } // Mã bưu điện (tùy chọn) - Nullable
    public string AddressType { get; set; } = string.Empty; // Loại địa chỉ - Non-nullable, default to empty string (Consider enum default if applicable)
    public string? AddressLine2 { get; set; } // Dòng địa chỉ 2 (tùy chọn) - Nullable
    public string? ContactName { get; set; } // Tên người liên hệ (tùy chọn) - Nullable
    public string? ContactPhone { get; set; } // Số điện thoại liên hệ (tùy chọn) - Nullable
    public string? ContactEmail { get; set; } // Email liên hệ (tùy chọn) - Nullable
    public Guid? UserId { get; set; } // ID người dùng (tùy chọn)
    public User? User { get; set; } // Người dùng (Navigation)
}