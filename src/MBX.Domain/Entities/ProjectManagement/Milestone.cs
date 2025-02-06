using MBX.Domain.Common;

namespace MBX.Domain.Entities.ProjectManagement;

public class Milestone : BaseEntity
{
    public Guid ProjectId { get; set; } // ID dự án
    public Project Project { get; set; } = null!; // Dự án mà Milestone thuộc về (Navigation)
    public string MilestoneName { get; set; } = string.Empty; // Tên Milestone - Non-nullable, default to empty string
    public string? Description { get; set; } // Mô tả Milestone (tùy chọn) - Nullable
    public DateTime DueDate { get; set; } // Ngày đến hạn
    public DateTime? ActualCompletionDate { get; set; } // Ngày hoàn thành thực tế (tùy chọn) - Nullable
    public string MilestoneStatus { get; set; } = string.Empty; // Trạng thái Milestone - Non-nullable, default to empty string (Consider enum default if applicable)
    public decimal? BudgetedCost { get; set; } // Chi phí dự kiến (tùy chọn) - Nullable
    public decimal? ActualCost { get; set; } // Chi phí thực tế (tùy chọn) - Nullable
    public string? Notes { get; set; } // Ghi chú Milestone (tùy chọn) - Nullable
    public string? CustomFields { get; set; } // Trường tùy chỉnh (JSON) - Nullable
}