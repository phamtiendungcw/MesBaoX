namespace MBX.Application.Features.Reporting.DTOs;

public class DashboardDto
{
    public Guid Id { get; set; }
    public string DashboardName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public bool IsActive { get; set; }
}