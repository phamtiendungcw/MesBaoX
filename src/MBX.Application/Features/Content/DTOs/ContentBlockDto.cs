namespace MBX.Application.Features.Content.DTOs;

public class ContentBlockDto
{
    public Guid Id { get; set; }
    public string BlockName { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}