using MBX.Domain.Common;

namespace MBX.Domain.Entities.ProjectManagement;

public class ProjectResource : BaseEntity
{
    public Guid ProjectId { get; set; } // ID dự án
    public Project Project { get; set; } = null!; // Dự án mà ProjectResource thuộc về (Navigation)
    public string ResourceName { get; set; } = string.Empty; // Tên nguồn lực - Non-nullable, default to empty string
    public string ResourceType { get; set; } = string.Empty; // Loại nguồn lực - Non-nullable, default to empty string (Consider enum default if applicable)
    public decimal? EstimatedQuantity { get; set; } // Số lượng ước tính (tùy chọn) - Nullable
    public decimal? ActualQuantity { get; set; } // Số lượng thực tế (tùy chọn) - Nullable
    public string? UnitOfMeasure { get; set; } // Đơn vị đo lường (tùy chọn) - Nullable
    public decimal? UnitCost { get; set; } // Đơn giá (tùy chọn) - Nullable
    public decimal? TotalCost => ActualQuantity * UnitCost; // Tổng chi phí (tính toán)
    public string? Notes { get; set; } // Ghi chú ProjectResource (tùy chọn) - Nullable
    public string? CustomFields { get; set; } // Trường tùy chỉnh (JSON) - Nullable
}