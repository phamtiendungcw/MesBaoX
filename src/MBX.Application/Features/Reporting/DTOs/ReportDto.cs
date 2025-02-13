namespace MBX.Application.Features.Reporting.DTOs
{
    public class ReportDto
    {
        public Guid Id { get; set; }
        public string ReportName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Query { get; set; }
        public string? ReportType { get; set; }
        public bool IsActive { get; set; }
    }
}
