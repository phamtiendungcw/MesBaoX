namespace MBX.Application.Features.Logging.DTOs;

public class ActivityLogDto
{
    public Guid Id { get; set; }
    public Guid? UserId { get; set; }
    public string ActivityType { get; set; } = string.Empty;
    public string? ActivityDescription { get; set; }
    public DateTime Timestamp { get; set; }
    public string? IpAddress { get; set; }
    public string? EntityName { get; set; }
    public Guid? EntityId { get; set; }
    public bool IsActive { get; set; }
}