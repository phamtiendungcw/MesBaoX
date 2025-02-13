namespace MBX.Application.Features.Users.DTOs;

public class RoleDto
{
    public Guid Id { get; set; }
    public string RoleName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public bool IsActive { get; set; }
}