namespace MBX.Application.Features.Content.DTOs;

public class MenuItemDto
{
    public Guid Id { get; set; }
    public Guid MenuId { get; set; }
    public string MenuItemName { get; set; } = string.Empty;
    public bool IsActive { get; set; }
}