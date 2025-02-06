using MBX.Domain.Common;

namespace MBX.Domain.Entities.Core;

public class Department : BaseEntity
{
    public Guid CompanyId { get; set; } // ID công ty
    public Company Company { get; set; } = null!; // Công ty mà phòng ban thuộc về (Navigation)
    public string Name { get; set; } = string.Empty; // Tên phòng ban - Non-nullable, default to empty string
    public string? Description { get; set; } // Mô tả phòng ban (tùy chọn) - Nullable
    public Guid? ManagerId { get; set; } // ID người quản lý phòng ban (tùy chọn)
    public User? Manager { get; set; } // Người quản lý phòng ban (Navigation)
    public Guid? LocationId { get; set; } // ID địa điểm phòng ban (tùy chọn)
    public Location Location { get; set; } = null!; // Địa điểm phòng ban (Navigation)
    public Guid? ParentDepartmentId { get; set; } // ID phòng ban cha (tùy chọn)
    public Department? ParentDepartment { get; set; } // Phòng ban cha (Navigation)
    public string? CostCenterCode { get; set; } // Mã trung tâm chi phí (tùy chọn) - Nullable
    public ICollection<User> Users { get; set; } = new List<User>(); // Danh sách Users (Navigation)
    public ICollection<Department> ChildDepartments { get; set; } = new List<Department>(); // Danh sách phòng ban con (Navigation)
}