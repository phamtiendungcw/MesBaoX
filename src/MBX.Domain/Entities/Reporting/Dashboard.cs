using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Reporting;

public class Dashboard : BaseEntity
{
    [Required]
    [MaxLength(255)]
    public string DashboardName { get; set; } = string.Empty; // Tên dashboard (ví dụ: "Dashboard bán hàng", "Dashboard kho") (bắt buộc, độ dài tối đa 255 ký tự)

    [MaxLength(1000)]
    public string? Description { get; set; } // Mô tả dashboard (không bắt buộc, độ dài tối đa 1000 ký tự)

    #region Navigation properties

    public virtual ICollection<DashboardWidget> DashboardWidgets { get; set; } = new List<DashboardWidget>(); // Navigation property cho widget dashboard (danh sách các widget dashboard thuộc dashboard này)

    #endregion Navigation properties
}