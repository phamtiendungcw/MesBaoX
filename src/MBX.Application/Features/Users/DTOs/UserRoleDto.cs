namespace MBX.Application.Features.Users.DTOs;

public class UserRoleDto
{
    public Guid UserId { get; set; }
    public Guid RoleId { get; set; }
    public bool IsActive { get; set; }
}