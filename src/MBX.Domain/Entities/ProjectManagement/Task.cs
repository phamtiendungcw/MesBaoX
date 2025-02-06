using MBX.Domain.Common;

namespace MBX.Domain.Entities.ProjectManagement;

public class Task : BaseEntity
{
    public Guid ProjectId { get; set; } // ID dự án
    public Project Project { get; set; } = null!; // Dự án mà Task thuộc về (Navigation)
    public string TaskName { get; set; } = string.Empty; // Tên công việc - Non-nullable, default to empty string
    public string? Description { get; set; } // Mô tả công việc (tùy chọn) - Nullable
    public DateTime StartDate { get; set; } // Ngày bắt đầu công việc
    public DateTime? DueDate { get; set; } // Ngày đến hạn (tùy chọn) - Nullable
    public DateTime? ActualEndDate { get; set; } // Ngày kết thúc thực tế (tùy chọn) - Nullable
    public string TaskStatus { get; set; } = string.Empty; // Trạng thái công việc - Non-nullable, default to empty string (Consider enum default if applicable)
    public string TaskPriority { get; set; } = string.Empty; // Độ ưu tiên công việc - Non-nullable, default to empty string (Consider enum default if applicable)
    public decimal? EstimatedHours { get; set; } // Giờ ước tính (tùy chọn) - Nullable
    public decimal? ActualHours { get; set; } // Giờ thực tế (tùy chọn) - Nullable
    public decimal? PercentComplete { get; set; } // Phần trăm hoàn thành (tùy chọn) - Nullable
    public Guid? AssignedToUserId { get; set; } // ID người được giao việc (tùy chọn)
    public Core.User? AssignedToUser { get; set; } // Người được giao việc (Navigation)
    public Guid? ParentTaskId { get; set; } // ID công việc cha (tùy chọn)
    public Task? ParentTask { get; set; } // Công việc cha (Navigation)
    public string? Notes { get; set; } // Ghi chú công việc (tùy chọn) - Nullable
    public string? CustomFields { get; set; } // Trường tùy chỉnh (JSON) - Nullable
    public ICollection<TimeEntry> TimeEntries { get; set; } = null!; // Danh sách TimeEntries (Navigation)
}