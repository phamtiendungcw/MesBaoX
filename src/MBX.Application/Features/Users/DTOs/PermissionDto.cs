namespace MBX.Application.Features.Users.DTOs;

public class PermissionDto
{
    public Guid Id { get; set; }
    public string PermissionName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public bool IsActive { get; set; }
}