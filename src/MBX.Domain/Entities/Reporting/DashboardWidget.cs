using System.ComponentModel.DataAnnotations;

namespace MBX.Domain.Entities.Reporting;

public class DashboardWidget : BaseEntity
{
    [Required]
    public Guid DashboardId { get; set; } // ID dashboard (khóa ngoại đến bảng Dashboard, bắt buộc)

    public virtual Dashboard Dashboard { get; set; } = null!; // Navigation property cho dashboard (bắt buộc)
    public Guid? ReportId { get; set; } // ID báo cáo (khóa ngoại đến bảng Report, có thể null nếu widget không hiển thị báo cáo cụ thể)
    public virtual Report? Report { get; set; } // Navigation property cho báo cáo (có thể null)

    [MaxLength(50)]
    public string? WidgetType { get; set; } // Loại widget (ví dụ: "LineChart", "PieChart", "Statistic", "Table") (không bắt buộc, độ dài tối đa 50 ký tự)

    public string? Configuration { get; set; } // Cấu hình widget (không bắt buộc, có thể là JSON hoặc XML, chứa các tùy chỉnh hiển thị widget)
}