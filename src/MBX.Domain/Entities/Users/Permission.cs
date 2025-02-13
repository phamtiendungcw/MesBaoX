using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Users;

public class Permission : BaseEntity
{
    [Required]
    [MaxLength(255)]
    public string PermissionName { get; set; } = string.Empty; // Tên quyền hạn (ví dụ: "Xem sản phẩm", "Thêm đơn hàng") (bắt buộc, độ dài tối đa 255 ký tự, duy nhất trong hệ thống)

    [MaxLength(1000)]
    public string? Description { get; set; } // Mô tả quyền hạn (không bắt buộc, độ dài tối đa 1000 ký tự)

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>(); // Navigation property cho vai trò (quan hệ Many-to-Many, danh sách các vai trò có quyền hạn này)
}