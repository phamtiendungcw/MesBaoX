using MBX.Domain.Entities.Users;

namespace MBX.Domain.Repositories.Services;

public interface IUserRoleRepository : IGenericRepository<UserRole>
{
    Task<IReadOnlyList<UserRole>> GetUserRolesByUserAsync(Guid userId);
    Task<IReadOnlyList<UserRole>> GetUserRolesByRoleAsync(Guid roleId);
    Task<IReadOnlyList<User>> GetUsersInRoleAsync(Guid roleId);
}