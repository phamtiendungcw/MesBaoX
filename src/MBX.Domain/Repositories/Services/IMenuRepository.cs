using MBX.Domain.Entities.Content;

namespace MBX.Domain.Repositories.Services;

public interface IMenuRepository : IGenericRepository<Menu>
{
    Task<Menu?> GetMenuByNameAsync(string menuName);
    Task<IReadOnlyList<Menu>> GetActiveMenusAsync();
    Task<IReadOnlyList<Menu>> GetMenusWithMenuItemsAsync();
}