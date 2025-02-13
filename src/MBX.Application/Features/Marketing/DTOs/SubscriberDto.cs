namespace MBX.Application.Features.Marketing.DTOs;

public class SubscriberDto
{
    public Guid Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}