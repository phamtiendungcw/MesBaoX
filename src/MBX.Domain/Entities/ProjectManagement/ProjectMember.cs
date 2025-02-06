using MBX.Domain.Common;

namespace MBX.Domain.Entities.ProjectManagement;

public class ProjectMember : BaseEntity
{
    public Guid ProjectId { get; set; } // ID dự án
    public Project Project { get; set; } = null!; // Dự án mà ProjectMember thuộc về (Navigation)
    public Guid UserId { get; set; } // ID người dùng
    public Core.User User { get; set; } = null!; // Người dùng (Navigation)
    public string RoleInProject { get; set; } = string.Empty; // Vai trò trong dự án - Non-nullable, default to empty string
    public decimal? HourlyRate { get; set; } // Đơn giá giờ (tùy chọn) - Nullable
    public string? Notes { get; set; } // Ghi chú ProjectMember (tùy chọn) - Nullable
    public string? CustomFields { get; set; } // Trường tùy chỉnh (JSON) - Nullable
}