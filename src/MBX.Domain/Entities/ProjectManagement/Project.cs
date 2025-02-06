using MBX.Domain.Common;

namespace MBX.Domain.Entities.ProjectManagement
{
    public class Project : BaseEntity
    {
        public Guid CompanyId { get; set; } // ID công ty
        public Core.Company Company { get; set; } = null!; // Công ty mà dự án thuộc về (Navigation)
        public string ProjectName { get; set; } = string.Empty; // Tên dự án - Non-nullable, default to empty string
        public string? ProjectCode { get; set; } // Mã dự án (tùy chọn) - Nullable
        public string? Description { get; set; } // Mô tả dự án (tùy chọn) - Nullable
        public DateTime StartDate { get; set; } // Ngày bắt đầu dự án
        public DateTime? EndDate { get; set; } // Ngày kết thúc dự kiến (tùy chọn) - Nullable
        public DateTime? ActualEndDate { get; set; } // Ngày kết thúc thực tế (tùy chọn) - Nullable
        public string ProjectStatus { get; set; } = string.Empty; // Trạng thái dự án - Non-nullable, default to empty string (Consider enum default if applicable)
        public string ProjectPriority { get; set; } = string.Empty; // Độ ưu tiên dự án - Non-nullable, default to empty string (Consider enum default if applicable)
        public decimal? Budget { get; set; } // Ngân sách dự án (tùy chọn) - Nullable
        public decimal? ActualCost { get; set; } // Chi phí thực tế (tùy chọn) - Nullable
        public Guid? ProjectManagerId { get; set; } // ID người quản lý dự án (tùy chọn)
        public Core.User? ProjectManager { get; set; } // Người quản lý dự án (Navigation)
        public Guid? CustomerId { get; set; } // ID khách hàng (tùy chọn)
        public Sales.Customer? Customer { get; set; } // Khách hàng (Navigation)
        public Guid? DepartmentId { get; set; } // ID phòng ban (tùy chọn)
        public Core.Department? Department { get; set; } // Phòng ban (Navigation)
        public Guid? SalesOpportunityId { get; set; } // ID cơ hội bán hàng (tùy chọn)
        public Sales.SalesOpportunity? SalesOpportunity { get; set; } // Cơ hội bán hàng (Navigation)
        public string? Notes { get; set; } // Ghi chú dự án (tùy chọn) - Nullable
        public string? CustomFields { get; set; } // Trường tùy chỉnh (JSON) - Nullable
        public ICollection<Task> Tasks { get; set; } = null!; // Danh sách Tasks (Navigation)
        public ICollection<Milestone> Milestones { get; set; } = null!; // Danh sách Milestones (Navigation)
        public ICollection<ProjectMember> ProjectMembers { get; set; } = null!; // Danh sách ProjectMembers (Navigation)
        public ICollection<ProjectResource> ProjectResources { get; set; } = null!; // Danh sách ProjectResources (Navigation)

    }
}