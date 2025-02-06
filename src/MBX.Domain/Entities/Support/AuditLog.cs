using MBX.Domain.Common;

namespace MBX.Domain.Entities.Support;

public class AuditLog : BaseEntity
{
    public string? UserId { get; set; } // ID người dùng (tùy chọn) - Nullable
    public string Action { get; set; } = string.Empty; // Hành động - Non-nullable, default to empty string
    public string EntityName { get; set; } = string.Empty; // Tên Entity bị thay đổi - Non-nullable, default to empty string
    public string? EntityId { get; set; } // ID Entity bị thay đổi (tùy chọn) - Nullable
    public DateTime Timestamp { get; set; } = DateTime.UtcNow; // Thời điểm thay đổi (mặc định UTC now)
    public string? OldValues { get; set; } // Giá trị cũ (JSON or XML string) (tùy chọn) - Nullable
    public string? NewValues { get; set; } // Giá trị mới (JSON or XML string) (tùy chọn) - Nullable
    public string? Changes { get; set; } // Chi tiết thay đổi (Diff) (tùy chọn) - Nullable
    public string? Notes { get; set; } // Ghi chú (tùy chọn) - Nullable
}