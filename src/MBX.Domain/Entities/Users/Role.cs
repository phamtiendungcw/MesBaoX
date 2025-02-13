using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Users;

public class Role : BaseEntity
{
    [Required]
    [MaxLength(255)]
    public string RoleName { get; set; } = string.Empty; // Tên vai trò (ví dụ: "Admin", "Quản lý sản phẩm", "Nhân viên bán hàng") (bắt buộc, độ dài tối đa 255 ký tự, duy nhất trong hệ thống)

    [MaxLength(1000)]
    public string? Description { get; set; } // Mô tả vai trò (không bắt buộc, độ dài tối đa 1000 ký tự)

    public virtual ICollection<User> Users { get; set; } = new List<User>(); // Navigation property cho người dùng (quan hệ Many-to-Many, danh sách các người dùng có vai trò này)
    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>(); // Navigation property cho quyền hạn (quan hệ Many-to-Many, danh sách các quyền hạn của vai trò)
}