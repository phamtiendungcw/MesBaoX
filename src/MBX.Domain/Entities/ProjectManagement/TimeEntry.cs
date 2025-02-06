using MBX.Domain.Common;

namespace MBX.Domain.Entities.ProjectManagement;

public class TimeEntry : BaseEntity
{
    public Guid TaskId { get; set; } // ID công việc
    public Task Task { get; set; } = null!; // Công việc mà TimeEntry thuộc về (Navigation)
    public Guid UserId { get; set; } // ID người dùng
    public Core.User User { get; set; } = null!; // Người dùng (Navigation)
    public DateTime EntryDate { get; set; } = DateTime.UtcNow; // Ngày ghi TimeEntry (mặc định UTC now)
    public decimal HoursWorked { get; set; } // Số giờ làm việc
    public string? Description { get; set; } // Mô tả công việc (tùy chọn) - Nullable
    public string? Notes { get; set; } // Ghi chú TimeEntry (tùy chọn) - Nullable
    public string? CustomFields { get; set; } // Trường tùy chỉnh (JSON) - Nullable
}