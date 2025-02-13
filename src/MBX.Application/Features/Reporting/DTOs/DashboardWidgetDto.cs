namespace MBX.Application.Features.Reporting.DTOs;

public class DashboardWidgetDto
{
    public Guid Id { get; set; }
    public Guid DashboardId { get; set; }
    public Guid? ReportId { get; set; }
    public string? WidgetType { get; set; }
    public string? Configuration { get; set; }
    public bool IsActive { get; set; }
}