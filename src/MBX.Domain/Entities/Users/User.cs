using MBX.Domain.Entities.Content;
using MBX.Domain.Entities.Customers;
using MBX.Domain.Entities.Logging;

using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Users;

public class User : BaseEntity
{
    [Required][MaxLength(255)] public string Username { get; set; } = string.Empty; // Tên đăng nhập (bắt buộc, độ dài tối đa 255 ký tự, duy nhất trong hệ thống)
    [Required][MaxLength(255)] public string PasswordHash { get; set; } = string.Empty; // Hash mật khẩu (bắt buộc, độ dài tối đa 255 ký tự, dùng để lưu mật khẩu đã hash)
    [Required][MaxLength(255)] public string PasswordSalt { get; set; } = string.Empty; // Salt mật khẩu (bắt buộc, độ dài tối đa 255 ký tự, dùng để tăng cường bảo mật khi hash mật khẩu)
    [Required][MaxLength(255)] public string FirstName { get; set; } = string.Empty; // Tên người dùng (bắt buộc, độ dài tối đa 255 ký tự)
    [Required][MaxLength(255)] public string LastName { get; set; } = string.Empty; // Họ người dùng (bắt buộc, độ dài tối đa 255 ký tự)

    [Required]
    [MaxLength(255)]
    [EmailAddress] // DataAnnotation để validate email format
    public string Email { get; set; } = string.Empty; // Email người dùng (bắt buộc, độ dài tối đa 255 ký tự, định dạng email, duy nhất trong hệ thống)

    [MaxLength(20)] public string? PhoneNumber { get; set; } // Số điện thoại người dùng (không bắt buộc, độ dài tối đa 20 ký tự)

    #region Navigation properties

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>(); // Navigation property cho vai trò (quan hệ Many-to-Many, danh sách các vai trò của người dùng)
    public virtual ICollection<CustomerNote> CustomerNotes { get; set; } = new List<CustomerNote>(); // Navigation property cho ghi chú khách hàng (danh sách các ghi chú khách hàng do người dùng này tạo)
    public virtual ICollection<MediaLibrary> MediaLibraries { get; set; } = new List<MediaLibrary>(); // Navigation property cho thư viện media (danh sách các media file do người dùng này tải lên)
    public virtual ICollection<ActivityLog> ActivityLogs { get; set; } = new List<ActivityLog>(); // Navigation property cho nhật ký hoạt động (danh sách các hoạt động do người dùng này thực hiện)

    #endregion
}