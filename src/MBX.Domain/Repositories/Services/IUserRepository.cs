using MBX.Domain.Entities.Users;

namespace MBX.Domain.Repositories.Services;

public interface IUserRepository : IGenericRepository<User>
{
    Task<User?> GetUserByUsernameAsync(string username);
    Task<User?> GetUserByEmailAsync(string email);
    Task<IReadOnlyList<User>> GetActiveUsersAsync();
    Task<IReadOnlyList<User>> SearchUsersByNameAsync(string nameKeyword);
}