using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Users;

public class UserRole : BaseEntity
{
    [Required]
    public Guid UserId { get; set; } // ID người dùng (khóa ngoại đến bảng User, bắt buộc)

    public virtual User User { get; set; } = null!; // Navigation property cho người dùng (bắt buộc)

    [Required]
    public Guid RoleId { get; set; } // ID vai trò (khóa ngoại đến bảng Role, bắt buộc)

    public virtual Role Role { get; set; } = null!; // Navigation property cho vai trò (bắt buộc)
    public DateTime AssignedDate { get; set; } = DateTime.UtcNow;
}