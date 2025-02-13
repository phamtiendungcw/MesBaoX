using MBX.Domain.Entities.Users;

namespace MBX.Domain.Repositories.Services;

public interface IPermissionRepository : IGenericRepository<Permission>
{
    Task<Permission?> GetPermissionByNameAsync(string permissionName);
    Task<IReadOnlyList<Permission>> GetPermissionsForRoleAsync(Guid roleId);
}