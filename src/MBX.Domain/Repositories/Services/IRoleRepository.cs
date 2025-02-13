using MBX.Domain.Entities.Users;

namespace MBX.Domain.Repositories.Services;

public interface IRoleRepository : IGenericRepository<Role>
{
    Task<Role?> GetRoleNameAsync(string roleName);
    Task<IReadOnlyList<Role>> GetRolesWithUsersAsync();
    Task<IReadOnlyList<Role>> GetRolesWithPermissionsAsync();
}