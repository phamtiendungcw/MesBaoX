using MBX.Domain.Common;
using MBX.Domain.Entities.ProjectManagement;
using MBX.Domain.Entities.Support;

namespace MBX.Domain.Entities.Core;

public class User : BaseEntity
{
    public Guid CompanyId { get; set; } // ID công ty
    public Company Company { get; set; } = null!; // Công ty mà người dùng thuộc về (Navigation)
    public string Username { get; set; } = string.Empty; // Tên đăng nhập - Non-nullable, default to empty string
    public string PasswordHash { get; set; } = string.Empty; // Hash mật khẩu - Non-nullable, default to empty string
    public string Email { get; set; } = string.Empty; // Email người dùng - Non-nullable, default to empty string
    public string? PhoneNumber { get; set; } // Số điện thoại người dùng (tùy chọn) - Nullable
    public string FirstName { get; set; } = string.Empty; // Tên người dùng - Non-nullable, default to empty string
    public string LastName { get; set; } = string.Empty; // Họ người dùng - Non-nullable, default to empty string
    public string FullName => $"{FirstName} {LastName}"; // Tên đầy đủ (tính toán)
    public string? JobTitle { get; set; } // Chức danh (tùy chọn) - Nullable
    public Guid? DepartmentId { get; set; } // ID phòng ban (tùy chọn)
    public Department? Department { get; set; } // Phòng ban (Navigation)
    public Guid? RoleId { get; set; } // ID vai trò (tùy chọn)
    public Role? Role { get; set; } // Vai trò (Navigation)
    public string? EmployeeId { get; set; } // Mã nhân viên (tùy chọn) - Nullable
    public DateTime? HireDate { get; set; } // Ngày tuyển dụng (tùy chọn) - Nullable
    public DateTime? TerminationDate { get; set; } // Ngày nghỉ việc (tùy chọn) - Nullable
    public Guid? ReportToUserId { get; set; } // ID người quản lý trực tiếp (tùy chọn)
    public User? ReportToUser { get; set; } // Người quản lý trực tiếp (Navigation)
    public Guid? LocationId { get; set; } // ID địa điểm làm việc (tùy chọn)
    public Location Location { get; set; } = null!; // Địa điểm làm việc (Navigation)
    public string? SignatureImageUrl { get; set; } // URL chữ ký số (tùy chọn) - Nullable
    public string? PersonalEmail { get; set; } // Email cá nhân (tùy chọn) - Nullable
    public string? PersonalPhoneNumber { get; set; } // Số điện thoại cá nhân (tùy chọn) - Nullable
    public string? Address { get; set; } // Địa chỉ nhà riêng (tùy chọn) - Nullable
    public string? EmergencyContactName { get; set; } // Tên người liên hệ khẩn cấp (tùy chọn) - Nullable
    public string? EmergencyContactPhone { get; set; } // Số điện thoại người liên hệ khẩn cấp (tùy chọn) - Nullable
    public string? CustomFields { get; set; } // Trường tùy chỉnh (JSON) - Nullable
    public DateTime? LastLoginDate { get; set; } // Lần đăng nhập cuối (tùy chọn) - Nullable
    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>(); // Danh sách UserRoles (Navigation)
    public ICollection<Order.Order> Orders { get; set; } = new List<Order.Order>(); // Danh sách Orders (Navigation)
    public ICollection<Address> Addresses { get; set; } = new List<Address>(); // Danh sách Addresses (Navigation)
    public ICollection<TimeEntry> TimeEntries { get; set; } = new List<TimeEntry>(); // Danh sách Time Entries (Navigation)
    public ICollection<ExpenseClaim> ExpenseClaims { get; set; } = new List<ExpenseClaim>(); // Danh sách Expense Claims (Navigation)
}