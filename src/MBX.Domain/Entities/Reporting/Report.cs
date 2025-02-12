using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Reporting;

public class Report : BaseEntity
{
    [Required]
    [MaxLength(255)]
    public string ReportName { get; set; } = string.Empty; // Tên báo cáo (ví dụ: "Doanh thu theo tháng", "Sản phẩm bán chạy") (bắt buộc, độ dài tối đa 255 ký tự)

    [MaxLength(1000)]
    public string? Description { get; set; } // Mô tả báo cáo (không bắt buộc, độ dài tối đa 1000 ký tự)

    public string? Query { get; set; } // Câu truy vấn dữ liệu báo cáo (không bắt buộc, có thể là SQL, LINQ, hoặc ngôn ngữ truy vấn khác)

    [MaxLength(50)]
    public string? ReportType { get; set; } // Loại báo cáo (ví dụ: "Chart", "Table", "KPI") (không bắt buộc, độ dài tối đa 50 ký tự)

    #region Navigation properties

    public virtual ICollection<DashboardWidget> DashboardWidgets { get; set; } = new List<DashboardWidget>(); // Navigation property cho widget dashboard (danh sách các widget dashboard hiển thị báo cáo này)

    #endregion Navigation properties
}