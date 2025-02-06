using MBX.Domain.Common;

namespace MBX.Domain.Entities.Core;

public class Role : BaseEntity
{
    public Guid CompanyId { get; set; } // ID công ty
    public Company Company { get; set; } = null!; // Công ty mà vai trò thuộc về (Navigation)
    public string Name { get; set; } = string.Empty; // Tên vai trò - Non-nullable, default to empty string
    public string? Description { get; set; } // Mô tả vai trò (tùy chọn) - Nullable
    public string PermissionsJson { get; set; } = string.Empty; // Quyền hạn (JSON) - Non-nullable, default to empty string
    public bool IsSystemRole { get; set; } // Vai trò hệ thống (true/false)
    public string RoleType { get; set; } = string.Empty; // Loại vai trò - Non-nullable, default to empty string (Consider enum default if applicable)
    public Guid? ParentRoleId { get; set; } // ID vai trò cha (tùy chọn)
    public Role? ParentRole { get; set; } // Vai trò cha (Navigation)
    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>(); // Danh sách UserRoles (Navigation)
    public ICollection<Role> ChildRoles { get; set; } = new List<Role>(); // Danh sách vai trò con (Navigation)
}