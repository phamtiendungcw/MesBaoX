using MBX.Domain.Common;
using MBX.Domain.Entities.Core;

namespace MBX.Domain.Entities.Product;

public class Supplier : BaseEntity
{
    public Guid CompanyId { get; set; } // ID công ty
    public Company Company { get; set; } = null!; // Công ty mà nhà cung cấp thuộc về (Navigation)
    public string Name { get; set; } = string.Empty; // Tên nhà cung cấp - Non-nullable, default to empty string
    public string? ContactEmail { get; set; } // Email liên hệ (tùy chọn) - Nullable
    public string? ContactPhone { get; set; } // Số điện thoại liên hệ (tùy chọn) - Nullable
    public string? Address { get; set; } // Địa chỉ nhà cung cấp (tùy chọn) - Nullable
    public string? TaxCode { get; set; } // Mã số thuế nhà cung cấp (tùy chọn) - Nullable
    public string? BankAccountNumber { get; set; } // Số tài khoản ngân hàng (tùy chọn) - Nullable
    public string? BankName { get; set; } // Tên ngân hàng (tùy chọn) - Nullable
    public string? SwiftCode { get; set; } // Mã Swift Code (tùy chọn) - Nullable
    public string SupplierType { get; set; } = string.Empty; // Loại nhà cung cấp - Non-nullable, default to empty string (Consider enum default if applicable)
    public string? Notes { get; set; } // Ghi chú (tùy chọn) - Nullable
    public ICollection<Product> Products { get; set; } = new List<Product>(); // Danh sách Products (Navigation)
}