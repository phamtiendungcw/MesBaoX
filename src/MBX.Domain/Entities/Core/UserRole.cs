namespace MBX.Domain.Entities.Core;

public class UserRole
{
    public Guid UserId { get; set; } // ID người dùng
    public User User { get; set; } = null!; // Người dùng (Navigation)
    public Guid RoleId { get; set; } // ID vai trò
    public Role Role { get; set; } = null!; // Vai trò (Navigation)
}