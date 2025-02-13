namespace MBX.Application.Features.Content.DTOs;

public class MenuDto
{
    public Guid Id { get; set; }
    public string MenuName { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}